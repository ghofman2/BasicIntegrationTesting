using Microsoft.CSharp;
using Ninject;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using Vault.Data.Interfaces;
using Vault.Data.Models;
using Vault.Data.Models.XmlModels;
using Vault.Data.ViewModels;

namespace Vault.Controllers
{
  public class FileUploadController : Controller
  {
    IFileUploadRepository _fileUploadRepo;

    [Inject]
    public FileUploadController(IFileUploadRepository fileUploadRepo)
    {
      _fileUploadRepo = fileUploadRepo;
    }

    [HttpPost]
    public ActionResult UploadFile(HttpPostedFileBase file)
    {
      FileUpload fileUpload = new FileUpload();
      fileUpload.FileName = file.FileName;
      fileUpload.Extension = Path.GetExtension(file.FileName);
      FileUpload dbFileUpload = _fileUploadRepo.Save(fileUpload);
      var storageLocation = getStorageLocation(dbFileUpload);
      file.SaveAs(Path.Combine(storageLocation, dbFileUpload.Id.ToString() + dbFileUpload.Extension));
      return RedirectToAction("Index", "Cabinet", null);
    }

    public ActionResult DisplayCcda()
    {
      XmlDocument doc = new XmlDocument();
      doc.Load(@"D:\VaultStorage\00000000\00000008.xml");
      CcdaModel vm = new CcdaModel();
      TraverseTree(doc.ChildNodes, vm);
      return View(vm);
    }

    private String getStorageLocation(FileUpload fileUpload)
    {
      var fileId = fileUpload.Id;
      string fileNameFormat = "00000000.##";
      string fileName = fileId.ToString(fileNameFormat);
      string folderName = fileName.Remove(fileName.Length - 3) + "000";
      string storagePath = Path.Combine(@"D:\VaultStorage\", folderName);
      Directory.CreateDirectory(storagePath);
      return storagePath;
    }

    private CcdaModel TraverseTree(XmlNodeList nodes, CcdaModel ccda)
    {

      foreach (XmlNode node in nodes)
      {
        if (node.Name.Equals("ClinicalDocument"))
        {
          ccda.DocumentTitle = GetInnerTextForNodeIfExists(node, new List<String> { "title" });
        }

        if (node.Name.Equals("patientRole"))
        {
          ccda.PatientContainer.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "telecom" }, "value");
          ccda.PatientContainer.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "addr", "streetAddressLine" });
          ccda.PatientContainer.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "addr", "city" });
          ccda.PatientContainer.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "addr", "state" });
          ccda.PatientContainer.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "addr", "postalCode" });


          ccda.PatientContainer.Patient.FirstName = GetInnerTextForNodeIfExists(node, new List<String> { "patient", "name", "given" });
          ccda.PatientContainer.Patient.LastName = GetInnerTextForNodeIfExists(node, new List<String> { "patient", "name", "family" });
          ccda.PatientContainer.Patient.Gender = GetAttributeForNodeIfExists(node, new List<String> { "patient", "administrativeGenderCode" }, "displayName");
          ccda.PatientContainer.Patient.Race = GetAttributeForNodeIfExists(node, new List<String> { "patient", "raceCode" }, "displayName");
          ccda.PatientContainer.Patient.Ethnicity = GetAttributeForNodeIfExists(node, new List<String> { "patient", "ethnicGroupCode" }, "displayName");
          ccda.PatientContainer.Patient.Language = GetAttributeForNodeIfExists(node, new List<String> { "patient", "languageCommunication", "languageCode" }, "code");
          ccda.PatientContainer.Patient.BirthDate = GetAttributeForNodeIfExists(node, new List<String> { "patient", "birthTime" }, "value");


          ccda.PatientContainer.ProviderOrganization.Name = GetInnerTextForNodeIfExists(node, new List<String> { "providerOrganization", "name" });
          ccda.PatientContainer.ProviderOrganization.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "providerOrganization", "telecom" }, "value");
          ccda.PatientContainer.ProviderOrganization.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "providerOrganization", "addr", "streetAddressLine" });
          ccda.PatientContainer.ProviderOrganization.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "providerOrganization", "addr", "city" });
          ccda.PatientContainer.ProviderOrganization.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "providerOrganization", "addr", "state" });
          ccda.PatientContainer.ProviderOrganization.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "providerOrganization", "addr", "postalCode" });

        }
        if (node.Name.Equals("author"))
        {
          ccda.Author.FirstName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "assignedPerson", "name", "given" });
          ccda.Author.LastName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "assignedPerson", "name", "family" });
          ccda.Author.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedAuthor", "telecom" }, "value");

          ccda.Author.ProviderOrganization.Name = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "representedOrganization", "name" });
          ccda.Author.ProviderOrganization.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedAuthor", "representedOrganization", "telecom" }, "value");

          ccda.Author.ProviderOrganization.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "representedOrganization", "addr", "streetAddressLine" });
          ccda.Author.ProviderOrganization.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "representedOrganization", "addr", "city" });
          ccda.Author.ProviderOrganization.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "representedOrganization", "addr", "state" });
          ccda.Author.ProviderOrganization.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "representedOrganization", "addr", "postalCode" });


          ccda.Author.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "addr", "streetAddressLine" });
          ccda.Author.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "addr", "city" });
          ccda.Author.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "addr", "state" });
          ccda.Author.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedAuthor", "addr", "postalCode" });

        }
        if (node.Name.Equals("informant"))
        {

          ccda.Informant.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "streetAddressLine" });
          ccda.Informant.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "city" });
          ccda.Informant.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "state" });
          ccda.Informant.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "postalCode" });

          ccda.Informant.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedEntity", "telecom" }, "value");
          ccda.Informant.FirstName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "assignedPerson", "name", "given" });
          ccda.Informant.LastName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "assignedPerson", "name", "family" });
          ccda.Informant.RepresentedOrganization.Name = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "name" });

          ccda.Informant.RepresentedOrganization.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "streetAddressLine" });
          ccda.Informant.RepresentedOrganization.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "city" });
          ccda.Informant.RepresentedOrganization.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "state" });
          ccda.Informant.RepresentedOrganization.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "postalCode" });


        }
        if (node.Name.Equals("authenticator"))
        { 
          ccda.Authenticator.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "streetAddressLine" });
          ccda.Authenticator.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "city" });
          ccda.Authenticator.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "state" });
          ccda.Authenticator.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "postalCode" });
          ccda.Authenticator.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedEntity", "telecom" }, "value");
          ccda.Authenticator.FirstName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "assignedPerson", "name", "given" });
          ccda.Authenticator.LastName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "assignedPerson", "name", "family" });
          ccda.Authenticator.RepresentedOrganization.Name = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "name" });
          ccda.Authenticator.RepresentedOrganization.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "telecom" }, "value");
          ccda.Authenticator.RepresentedOrganization.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "streetAddressLine" });
          ccda.Authenticator.RepresentedOrganization.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "city" });
          ccda.Authenticator.RepresentedOrganization.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "state" });
          ccda.Authenticator.RepresentedOrganization.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "postalCode" });
        }
        if (node.Name.Equals("legalAuthenticator"))
        {
          ccda.LegalAuthenticator.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "streetAddressLine" });
          ccda.LegalAuthenticator.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "city" });
          ccda.LegalAuthenticator.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "state" });
          ccda.LegalAuthenticator.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "addr", "postalCode" });
          ccda.LegalAuthenticator.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedEntity", "telecom" }, "value");
          ccda.LegalAuthenticator.FirstName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "assignedPerson", "name", "given" });
          ccda.LegalAuthenticator.LastName = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "assignedPerson", "name", "family" });
          ccda.LegalAuthenticator.RepresentedOrganization.Name = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "name" });
          ccda.LegalAuthenticator.RepresentedOrganization.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "telecom" }, "value");
          ccda.LegalAuthenticator.RepresentedOrganization.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "streetAddressLine" });
          ccda.LegalAuthenticator.RepresentedOrganization.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "city" });
          ccda.LegalAuthenticator.RepresentedOrganization.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "state" });
          ccda.LegalAuthenticator.RepresentedOrganization.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedEntity", "representedOrganization", "addr", "postalCode" });
        }
        if (node.Name.Equals("custodian"))
        {
          ccda.Custodian.Name = GetInnerTextForNodeIfExists(node, new List<String> { "assignedCustodian", "representedCustodianOrganization", "name" });
          ccda.Custodian.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "assignedCustodian", "representedCustodianOrganization", "telecom" }, "value");
          ccda.Custodian.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "assignedCustodian", "representedCustodianOrganization", "addr", "streetAddressLine" });
          ccda.Custodian.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "assignedCustodian", "representedCustodianOrganization", "addr", "city" });
          ccda.Custodian.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "assignedCustodian", "representedCustodianOrganization", "addr", "state" });
          ccda.Custodian.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "assignedCustodian", "representedCustodianOrganization", "addr", "postalCode" });
        }
        if (node.Name.Equals("documentationOf"))
        {
          ccda.Performer.Time = GetAttributeForNodeIfExists(node, new List<String> { "serviceEvent", "effectiveTime", "low" }, "value");
          ccda.Performer.TelephoneNumber = GetAttributeForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "telecom" }, "value");
          ccda.Performer.AssignedPersonFirstName = GetInnerTextForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "assignedPerson", "name", "given" });
          ccda.Performer.AssignedPersonLastName = GetInnerTextForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "assignedPerson", "name", "family" });
          ccda.Performer.Address.StreetAddress = GetInnerTextForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "addr", "streetAddressLine" });
          ccda.Performer.Address.City = GetInnerTextForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "addr", "city" });
          ccda.Performer.Address.State = GetInnerTextForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "addr", "state" });
          ccda.Performer.Address.PostalCode = GetInnerTextForNodeIfExists(node, new List<String> { "serviceEvent", "performer", "assignedEntity", "addr", "postalCode" });
        }
        //sections can contain components which contain sections. only add innermost sections
        if (node.Name.Equals("section") && GetInnerTextForNodeIfExists(node, new List<String> { "component" }) == "N/A")
        {
          Section section = new Section();
          section.Title = GetInnerTextForNodeIfExists(node, new List<String> { "title" });
          section.FreeText = node["text"].InnerXml;
          ccda.Sections.Add(section);
        }

        TraverseTree(node.ChildNodes, ccda);
      }

      return ccda;
    }

    private string GetInnerTextForNodeIfExists(XmlNode node, List<string> childNodes)
    {
      foreach (var nodeName in childNodes)
      {
        if (node != null)
        {
          node = node[nodeName];
        }
        else
        {
          return "N/A";
        }
      }

      return (node != null && !String.IsNullOrEmpty(node.InnerText)) ? node.InnerText : "N/A";
    }

    private string GetAttributeForNodeIfExists(XmlNode node, List<string> childNodes, string attributeName)
    {
      for (int i = 0; i < childNodes.Count; i++)
      {
        if (node != null)
        {
          if (i != (childNodes.Count-1))
          {
            node = node[childNodes[i]];
          }
          else
          {
            if (node[childNodes[i]] != null && node[childNodes[i]].HasAttribute(attributeName))
            {
              return node[childNodes[i]].GetAttribute(attributeName);
            }
          }
        }
        else
        {
          return "N/A";
        }
      }

      return "N/A";
    }

  }
}