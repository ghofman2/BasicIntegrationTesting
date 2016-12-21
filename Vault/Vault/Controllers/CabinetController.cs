using AutoMapper;
using Ninject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using Vault.Data.Interfaces;
using Vault.Data.Models;
using Vault.Data.Models.Medical;
using Vault.Data.ViewModels;

namespace Vault.Controllers
{
  public class CabinetController : Controller
  {

    private ICabinetRepository _cabinetRepo;

    [Inject]
    public CabinetController(ICabinetRepository cabinetRepo)
    {
      _cabinetRepo = cabinetRepo;
    }

    #region Controller Actions
    [HttpGet]
    public ActionResult Index()
    {
      var cabinets = _cabinetRepo.GetAll();

      var cabinetModels = Mapper.Map<List<Cabinet>, List<CabinetModel>>(cabinets);

      return View("Index", cabinetModels);
    }

    [HttpGet]
    public ActionResult Create()
    {
      var cabinetModel = new CabinetModel();
      return View("Create", cabinetModel);
    }

    public ActionResult GenerateCustomField(int fieldNumber)
    {
      var customFieldModel = new CustomField
      {
        FieldNumber = fieldNumber
      };
      return PartialView("_CustomFields", customFieldModel);
    }

    [HttpPost]
    public ActionResult Create(String cabinetName, IEnumerable<CustomField> customFields)
    {
      Cabinet cabinet = new Cabinet() { Name = cabinetName, CustomFields = customFields.ToList() };
      _cabinetRepo.Save(cabinet);

      List<Cabinet> cabinets = _cabinetRepo.GetAll();
      List<CabinetModel> cabinetModels = Mapper.Map<List<Cabinet>, List<CabinetModel>>(cabinets);
      return View("Index", cabinetModels);
    }
    #endregion

    #region NextGen stuff
    public ActionResult NextGen()
    {
      var dynamicNodes = new List<string>();

      var models = new List<XmlFieldDictionaryModel>();

      var tempFolder = Path.GetTempPath();
      var xmlFolder = Path.Combine(tempFolder, "CcdaSamples");

      var files = Directory.GetFiles(xmlFolder);

      foreach (var file in files)
      {
        var dictionary = CreateNewDictionary();

        using (var reader = XmlReader.Create(Path.Combine(xmlFolder, file)))
        {
          while (reader.Read())
          {
            if (!string.IsNullOrEmpty(reader.Name) && reader.IsStartElement())
            {
              if (!dynamicNodes.Contains(reader.Name))
              {
                dynamicNodes.Add(reader.Name);
              }

              if (dictionary.ContainsKey(reader.Name))
              {
                var oldVal = dictionary[reader.Name];
                dictionary[reader.Name] = oldVal + 1;
              }
              else
              {
                dictionary.Add(reader.Name, 1);
              }
            }
          }
        }

        var model = new XmlFieldDictionaryModel { FileName = file, FieldDictionary = dictionary };

        models.Add(model);
      }

      var parentModel = new DictionaryModels { DictionaryModel = models, NodeList = dynamicNodes };

      return View("NextGen", parentModel);
    }

    private Dictionary<string, int> CreateNewDictionary()
    {
      var nodes = new List<string> { "ClinicalDocument", "realmCode", "typeId", "templateId", "id", "code", "title", "effectiveTime", "confidentialityCode", "languageCode", "recordTarget", "patientRole", "addr", "streetAddressLine", "city", "state", "postalCode", "country", "telecom", "patient", "name", "family", "given", "administrativeGenderCode", "birthTime", "raceCode", "ethnicGroupCode", "languageCommunication", "preferenceInd", "providerOrganization", "author", "time", "assignedAuthor", "assignedPerson", "prefix", "assignedAuthoringDevice", "manufacturerModelName", "softwareName", "representedOrganization", "custodian", "assignedCustodian", "representedCustodianOrganization", "informationRecipient", "intendedRecipient", "receivedOrganization", "legalAuthenticator", "signatureCode", "assignedEntity", "authenticator", "documentationOf", "serviceEvent", "low", "high", "performer", "functionCode", "suffix", "componentOf", "encompassingEncounter", "dischargeDispositionCode", "component", "structuredBody", "section", "text", "content", "list", "caption", "item", "table", "thead", "tr", "th", "tbody", "td", "br", "entry", "observation", "reference", "statusCode", "value", "originalText", "entryRelationship", "act", "substanceAdministration", "period", "routeCode", "doseQuantity", "administrationUnitCode", "consumable", "manufacturedProduct", "manufacturedMaterial", "supply", "product", "translation", "participant", "participantRole", "playingEntity", "encounter", "approachSiteCode", "organizer", "interpretationCode", "center", "event", "procedure", "targetSiteCode", "sdtc:dischargeDispositionCode", "linkHtml", "externalDocument", "setId", "versionNumber", "maritalStatusCode", "informant", "lotNumberText", "referenceRange", "observationRange", "birthplace", "place", "manufacturerOrganization", "repeatNumber", "quantity", "paragraph", "dataEnterer", "priorityCode", "religiousAffiliationCode", "guardian", "guardianPerson", "modeCode", "relatedEntity", "relatedPerson", "associatedEntity", "associatedPerson", "methodCode", "colgroup", "col", "encounterParticipant" };

      var dictionary = new Dictionary<string, int>();

      foreach (var n in nodes)
      {
        dictionary.Add(n, 0);
      }

      return dictionary;
    }

    public ActionResult NextGenIndex()
    {
      //var models = new List<Vault.Data.Models.Medical.ClinicalDocument>();
      var models = new List<Vault.Data.Models.ClinicalDocument>();

      var tempFolder = Path.GetTempPath();
      var xmlFolder = Path.Combine(tempFolder, "CcdaSamples");

      var files = GetFileNames();

      foreach (var file in files)
      {
        Data.Models.ClinicalDocument model;

        model = GetClinicalDocument(Path.Combine(xmlFolder, file));

        //so far unable to serialize all inner text from a section node's text node into the structuredBody.section.text property
        //to overcome this, deserialize everything then go back and loop through each section building the text property for each via XPath
        foreach (var structuredBody in model.component.structuredBody.ToList())
        {
          XmlNamespaceManager manager = new XmlNamespaceManager(new NameTable());
          //must include namespace, todo: read this dyamically from file instead of hardcoding
          var nameSpace = "urn:hl7-org:v3";
          manager.AddNamespace("ns", nameSpace);
          var docNav = new XPathDocument(Path.Combine(xmlFolder, file));
          var nav = docNav.CreateNavigator();
          var xpath = "//ns:title[text() = '" + structuredBody.section.title+ "']";
          var nodeNav = nav.SelectSingleNode(xpath, manager);
          nodeNav.MoveToParent();
          nodeNav.MoveToChild("text", nameSpace);
          var innerxml = nodeNav.InnerXml;
          structuredBody.section.text = innerxml;
        }
        

        models.Add(model);
      }

      return View("NextGenIndex", models);
    }

    public Vault.Data.Models.ClinicalDocument GetClinicalDocument(string path)
    {
      Vault.Data.Models.ClinicalDocument doc;

      //remove colons from node attributes, serialization blows up with them there
      string text = System.IO.File.ReadAllText(path);
      text = text.Replace("xsi:type", "xsitype");

      System.IO.File.WriteAllText(path, text);

      using (var stream = new FileStream(path, FileMode.Open))
      {
        var serializer = new XmlSerializer(typeof(Vault.Data.Models.ClinicalDocument));
        doc = (Vault.Data.Models.ClinicalDocument)serializer.Deserialize(stream);
      }

      return doc;
    }

    public recordTarget GetRecordTarget(string xml)
    {
      var serializer = new XmlSerializer(typeof(recordTarget));

      recordTarget result;

      using (TextReader reader = new StringReader(xml))
      {
        result = (recordTarget)serializer.Deserialize(reader);
      }

      return result;
    }

    public recordTarget GetRecordTargetFromFile(string path)
    {
      recordTarget body;

      using (var stream = new FileStream(path, FileMode.Open))
      {
        var serializer = new XmlSerializer(typeof(recordTarget));
        body = (recordTarget)serializer.Deserialize(stream);
      }

      return body;
    }

    //public ActionResult NextGenIndex()
    //{
    //  var models = new List<Vault.Data.Models.Medical.ClinicalDocument>();

    //  var tempFolder = Path.GetTempPath();
    //  var xmlFolder = Path.Combine(tempFolder, "CcdaSamples");

    //  var files = GetFileNames();

    //  foreach (var file in files)
    //  {
    //    var model = new Vault.Data.Models.Medical.ClinicalDocument();

    //    using (var reader = XmlReader.Create(Path.Combine(xmlFolder, file)))
    //    {
    //      while (reader.Read())
    //      {
    //        if (!string.IsNullOrEmpty(reader.Name) && reader.IsStartElement())
    //        {
    //          if (reader.Name.Equals("title"))
    //          {
    //            model.Title = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("effectiveTime"))
    //          {
    //            if (!string.IsNullOrEmpty(reader.GetAttribute("value")))
    //            {
    //              model.EffectiveTime = ParseDateTime(reader.GetAttribute("value"));
    //            }
    //          }
    //          else if (reader.Name.Equals("recordTarget"))
    //          {
    //            model.RecordTarget = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("author"))
    //          {
    //            model.Author = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("informant"))
    //          {
    //            model.Informant = new List<string> { reader.ReadInnerXml() };
    //          }
    //          else if (reader.Name.Equals("custodian"))
    //          {
    //            model.Custodian = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("legalAuthenticator"))
    //          {
    //            model.LegalAuthenticator = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("authenticator"))
    //          {
    //            model.Authenticator = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("documentationOf"))
    //          {
    //            model.DocumentationOf = reader.ReadInnerXml();
    //          }
    //          else if (reader.Name.Equals("component"))
    //          {
    //            model.Component = reader.ReadInnerXml();
    //          }
    //        }
    //      }
    //    }

    //    models.Add(model);
    //  }

    //  return View("NextGenIndex", models);
    //}

    private List<string> GetFileNames()
    {
      return new List<string> {"170.314(b)(1)InPt_Discharge Summary CED Type.xml",
        "170.314(b)(2)InPt_Discharge Summary CED Type.xml",
        "170.314(b)(7)AMB_Patient5_SummaryOfCareCED Type.xml",
        "170.314(b)(7)AMB_Patient6_SummaryOfCareCED Type.xml",
        "170.314(b)(7)InPt_Patient1_CCDCED Type.xml",
        "170.314(b)(7)InPt_Patient2_CCDCED Type.xml",
        "170.314(b)(7)InPt_Patient3_CCDCED Type.xml",
        "170.314(e)(1)AMB_SummaryOfCareCED Type.xml",
        "170.314(e)(1)InPt_Discharge Summary CED Type.xml",
        "170.314(e)(2)AMB_SummaryOfCare CED Type.xml",
        "170.314B1_Amb_SummaryOfCare.xml",
        "170.314B2_Amb_CCD.xml",
        "170.314B2_Amb_SummaryOfCare.xml"};
    }

    private DateTime ParseDateTime(string value)
    {
      return DateTime.ParseExact(value.Substring(0, 14), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
    }

    //public ActionResult NextGen()
    //{
    //  var uniqueNodes = new List<string>();

    //  //var dictionary = new Dictionary<string, int>();

    //  var tempFolder = Path.GetTempPath();
    //  var xmlFolder = Path.Combine(tempFolder, "CcdaSamples");

    //  var files = Directory.GetFiles(xmlFolder);

    //  foreach (var file in files)
    //  {
    //    using (var reader = XmlReader.Create(Path.Combine(xmlFolder, file)))
    //    {
    //      while (reader.Read())
    //      {
    //        if (!string.IsNullOrEmpty(reader.Name) && reader.IsStartElement())
    //        {
    //          if (!uniqueNodes.Contains(reader.Name))
    //          {
    //            uniqueNodes.Add(reader.Name);
    //          }
    //        }
    //      }
    //    }
    //  }

    //  //using (var reader = XmlReader.Create(xmlPath))
    //  //{
    //  //  while (reader.Read())
    //  //  {
    //  //    if (!string.IsNullOrEmpty(reader.Name) && reader.IsStartElement())
    //  //    {
    //  //      if (dictionary.ContainsKey(reader.Name))
    //  //      {
    //  //        var oldVal = dictionary[reader.Name];
    //  //        dictionary[reader.Name] = oldVal + 1;
    //  //      }
    //  //      else
    //  //      {
    //  //        dictionary.Add(reader.Name, 1);
    //  //      }
    //  //    }
    //  //  }
    //  //}

    //  //var model = new XmlFieldDictionaryModel { FieldDictionary = dictionary };

    //  //    using (var reader = new StreamReader(xmlPath))
    //  //{
    //  //  results = (ClinicalDocument)serializer.Deserialize(reader);
    //  //}

    //  var model = new XmlFieldDictionaryModel { FieldNames = string.Format("\"{0}\"", string.Join("\",\"", uniqueNodes)) };

    //  return View("NextGen", model);
    //}
    #endregion
  }
}