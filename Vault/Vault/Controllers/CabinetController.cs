using AutoMapper;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vault.Data.Interfaces;
using Vault.Data.Models;
using Vault.Data.ViewModels;
using CommonLibrary;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

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

    //public ActionResult NextGen()
    //{
    //  var uniqueNodes = new List<string>();

    //  //var xmlPaths = new List<string> { "CCDA_Sample_NextGen_JonesIsabella.xml", "CCDA_EnterpriseEHR_Sample.xml" };

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