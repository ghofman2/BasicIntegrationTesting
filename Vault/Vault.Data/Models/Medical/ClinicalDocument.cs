using System;
using System.Collections.Generic;
using Vault.Data.Models.MedicalField;

namespace Vault.Data.Models.Medical
{
  public class ClinicalDocument
  {
    public TypeId TypeId { get; set; }

    public TemplateId[] TemplateIds { get; set; }

    public ClinicalDocumentId Id { get; set; }

    public ClinicalDocumentCode Code { get; set; }

    public string Title { get; set; }

    public DateTime EffectiveTime { get; set; }

    //confidentialityCode
    //  languageCode
    //  setId
    //  versionNumber

    public recordTarget RecordTarget { get; set; }

    public string Author { get; set; }

    public string DataEnterer { get; set; }

    public List<string> Informant { get; set; }

    public string Custodian { get; set; }

    public string InformationRecipient { get; set; }

    public string LegalAuthenticator { get; set; }

    public string Authenticator { get; set; }

    public string Participant { get; set; }

    public string DocumentationOf { get; set; }

    public string Authorization { get; set; }

    public string ComponentOf { get; set; }

    public string Component { get; set; }
  }
}
