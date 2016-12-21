using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models
{
  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:hl7-org:v3", IsNullable = false)]
  public partial class ClinicalDocument
  {

    private ClinicalDocumentRealmCode realmCodeField;

    private ClinicalDocumentTypeId typeIdField;

    private ClinicalDocumentTemplateId[] templateIdField;

    private ClinicalDocumentID idField;

    private ClinicalDocumentCode codeField;

    private string titleField;

    private ClinicalDocumentEffectiveTime effectiveTimeField;

    private ClinicalDocumentConfidentialityCode confidentialityCodeField;

    private ClinicalDocumentLanguageCode languageCodeField;

    private ClinicalDocumentRecordTarget recordTargetField;

    private ClinicalDocumentAuthor authorField;

    private ClinicalDocumentInformant informantField;

    private ClinicalDocumentCustodian custodianField;

    private ClinicalDocumentLegalAuthenticator legalAuthenticatorField;

    private ClinicalDocumentAuthenticator authenticatorField;

    private ClinicalDocumentDocumentationOf documentationOfField;

    private ClinicalDocumentComponent componentField;

    /// <remarks/>
    public ClinicalDocumentRealmCode realmCode
    {
      get
      {
        return this.realmCodeField;
      }
      set
      {
        this.realmCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentTypeId typeId
    {
      get
      {
        return this.typeIdField;
      }
      set
      {
        this.typeIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("templateId")]
    public ClinicalDocumentTemplateId[] templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public string title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentConfidentialityCode confidentialityCode
    {
      get
      {
        return this.confidentialityCodeField;
      }
      set
      {
        this.confidentialityCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLanguageCode languageCode
    {
      get
      {
        return this.languageCodeField;
      }
      set
      {
        this.languageCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTarget recordTarget
    {
      get
      {
        return this.recordTargetField;
      }
      set
      {
        this.recordTargetField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthor author
    {
      get
      {
        return this.authorField;
      }
      set
      {
        this.authorField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentInformant informant
    {
      get
      {
        return this.informantField;
      }
      set
      {
        this.informantField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentCustodian custodian
    {
      get
      {
        return this.custodianField;
      }
      set
      {
        this.custodianField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticator legalAuthenticator
    {
      get
      {
        return this.legalAuthenticatorField;
      }
      set
      {
        this.legalAuthenticatorField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticator authenticator
    {
      get
      {
        return this.authenticatorField;
      }
      set
      {
        this.authenticatorField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOf documentationOf
    {
      get
      {
        return this.documentationOfField;
      }
      set
      {
        this.documentationOfField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponent component
    {
      get
      {
        return this.componentField;
      }
      set
      {
        this.componentField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRealmCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentTypeId
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentEffectiveTime
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentConfidentialityCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLanguageCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTarget
  {

    private ClinicalDocumentRecordTargetPatientRole patientRoleField;

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRole patientRole
    {
      get
      {
        return this.patientRoleField;
      }
      set
      {
        this.patientRoleField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRole
  {

    private ClinicalDocumentRecordTargetPatientRoleID idField;

    private ClinicalDocumentRecordTargetPatientRoleAddr addrField;

    private ClinicalDocumentRecordTargetPatientRoleTelecom telecomField;

    private ClinicalDocumentRecordTargetPatientRolePatient patientField;

    private ClinicalDocumentRecordTargetPatientRoleProviderOrganization providerOrganizationField;

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRoleID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRoleAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRoleTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatient patient
    {
      get
      {
        return this.patientField;
      }
      set
      {
        this.patientField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRoleProviderOrganization providerOrganization
    {
      get
      {
        return this.providerOrganizationField;
      }
      set
      {
        this.providerOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleID
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    private string countryField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatient
  {

    private ClinicalDocumentRecordTargetPatientRolePatientName nameField;

    private ClinicalDocumentRecordTargetPatientRolePatientAdministrativeGenderCode administrativeGenderCodeField;

    private ClinicalDocumentRecordTargetPatientRolePatientBirthTime birthTimeField;

    private ClinicalDocumentRecordTargetPatientRolePatientRaceCode raceCodeField;

    private ClinicalDocumentRecordTargetPatientRolePatientEthnicGroupCode ethnicGroupCodeField;

    private ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunication languageCommunicationField;

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientAdministrativeGenderCode administrativeGenderCode
    {
      get
      {
        return this.administrativeGenderCodeField;
      }
      set
      {
        this.administrativeGenderCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientBirthTime birthTime
    {
      get
      {
        return this.birthTimeField;
      }
      set
      {
        this.birthTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientRaceCode raceCode
    {
      get
      {
        return this.raceCodeField;
      }
      set
      {
        this.raceCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientEthnicGroupCode ethnicGroupCode
    {
      get
      {
        return this.ethnicGroupCodeField;
      }
      set
      {
        this.ethnicGroupCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunication languageCommunication
    {
      get
      {
        return this.languageCommunicationField;
      }
      set
      {
        this.languageCommunicationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientName
  {

    private ClinicalDocumentRecordTargetPatientRolePatientNameFamily familyField;

    private ClinicalDocumentRecordTargetPatientRolePatientNameGiven givenField;

    private string useField;

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientNameFamily family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientNameGiven given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientNameFamily
  {

    private string qualifierField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string qualifier
    {
      get
      {
        return this.qualifierField;
      }
      set
      {
        this.qualifierField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientNameGiven
  {

    private string qualifierField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string qualifier
    {
      get
      {
        return this.qualifierField;
      }
      set
      {
        this.qualifierField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientAdministrativeGenderCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientBirthTime
  {

    private uint valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientRaceCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientEthnicGroupCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunication
  {

    private ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationTemplateId templateIdField;

    private ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationLanguageCode languageCodeField;

    private ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationPreferenceInd preferenceIndField;

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationLanguageCode languageCode
    {
      get
      {
        return this.languageCodeField;
      }
      set
      {
        this.languageCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationPreferenceInd preferenceInd
    {
      get
      {
        return this.preferenceIndField;
      }
      set
      {
        this.preferenceIndField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationLanguageCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRolePatientLanguageCommunicationPreferenceInd
  {

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleProviderOrganization
  {

    private ClinicalDocumentRecordTargetPatientRoleProviderOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentRecordTargetPatientRoleProviderOrganizationTelecom telecomField;

    private ClinicalDocumentRecordTargetPatientRoleProviderOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentRecordTargetPatientRoleProviderOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRoleProviderOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentRecordTargetPatientRoleProviderOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleProviderOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleProviderOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentRecordTargetPatientRoleProviderOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    private string countryField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthor
  {

    private ClinicalDocumentAuthorTime timeField;

    private ClinicalDocumentAuthorAssignedAuthor assignedAuthorField;

    /// <remarks/>
    public ClinicalDocumentAuthorTime time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthor assignedAuthor
    {
      get
      {
        return this.assignedAuthorField;
      }
      set
      {
        this.assignedAuthorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorTime
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthor
  {

    private ClinicalDocumentAuthorAssignedAuthorID idField;

    private ClinicalDocumentAuthorAssignedAuthorAddr addrField;

    private ClinicalDocumentAuthorAssignedAuthorTelecom[] telecomField;

    private ClinicalDocumentAuthorAssignedAuthorAssignedPerson assignedPersonField;

    private ClinicalDocumentAuthorAssignedAuthorRepresentedOrganization representedOrganizationField;

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("telecom")]
    public ClinicalDocumentAuthorAssignedAuthorTelecom[] telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorRepresentedOrganization representedOrganization
    {
      get
      {
        return this.representedOrganizationField;
      }
      set
      {
        this.representedOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    //private ClinicalDocumentAuthorAssignedAuthorAddrCountry countryField;

    private string countryField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorAddrCountry
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorTelecom
  {

    private string valueField;

    private string useField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorAssignedPerson
  {

    private ClinicalDocumentAuthorAssignedAuthorAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorAssignedPersonName
  {

    private string familyField;

    private string givenField;

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorRepresentedOrganization
  {

    private ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationTelecom telecomField;

    private ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthorAssignedAuthorRepresentedOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformant
  {

    private ClinicalDocumentInformantAssignedEntity assignedEntityField;

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntity
  {

    private ClinicalDocumentInformantAssignedEntityID idField;

    private ClinicalDocumentInformantAssignedEntityAddr addrField;

    private ClinicalDocumentInformantAssignedEntityTelecom[] telecomField;

    private ClinicalDocumentInformantAssignedEntityAssignedPerson assignedPersonField;

    private ClinicalDocumentInformantAssignedEntityRepresentedOrganization representedOrganizationField;

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("telecom")]
    public ClinicalDocumentInformantAssignedEntityTelecom[] telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityRepresentedOrganization representedOrganization
    {
      get
      {
        return this.representedOrganizationField;
      }
      set
      {
        this.representedOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityAssignedPerson
  {

    private ClinicalDocumentInformantAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityAssignedPersonName
  {

    private string familyField;

    private string givenField;

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityRepresentedOrganization
  {

    private ClinicalDocumentInformantAssignedEntityRepresentedOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentInformantAssignedEntityRepresentedOrganizationTelecom telecomField;

    private ClinicalDocumentInformantAssignedEntityRepresentedOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentInformantAssignedEntityRepresentedOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityRepresentedOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentInformantAssignedEntityRepresentedOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityRepresentedOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityRepresentedOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentInformantAssignedEntityRepresentedOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCustodian
  {

    private ClinicalDocumentCustodianAssignedCustodian assignedCustodianField;

    /// <remarks/>
    public ClinicalDocumentCustodianAssignedCustodian assignedCustodian
    {
      get
      {
        return this.assignedCustodianField;
      }
      set
      {
        this.assignedCustodianField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCustodianAssignedCustodian
  {

    private ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganization representedCustodianOrganizationField;

    /// <remarks/>
    public ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganization representedCustodianOrganization
    {
      get
      {
        return this.representedCustodianOrganizationField;
      }
      set
      {
        this.representedCustodianOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganization
  {

    private ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationTelecom telecomField;

    private ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentCustodianAssignedCustodianRepresentedCustodianOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    private string countryField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticator
  {

    private ClinicalDocumentLegalAuthenticatorTime timeField;

    private ClinicalDocumentLegalAuthenticatorSignatureCode signatureCodeField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntity assignedEntityField;

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorTime time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorSignatureCode signatureCode
    {
      get
      {
        return this.signatureCodeField;
      }
      set
      {
        this.signatureCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorTime
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorSignatureCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntity
  {

    private ClinicalDocumentLegalAuthenticatorAssignedEntityID idField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntityAddr addrField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntityTelecom telecomField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntityAssignedPerson assignedPersonField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganization representedOrganizationField;

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganization representedOrganization
    {
      get
      {
        return this.representedOrganizationField;
      }
      set
      {
        this.representedOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityAssignedPerson
  {

    private ClinicalDocumentLegalAuthenticatorAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityAssignedPersonName
  {

    private string givenField;

    private string familyField;

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganization
  {

    private ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationTelecom telecomField;

    private ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentLegalAuthenticatorAssignedEntityRepresentedOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticator
  {

    private ClinicalDocumentAuthenticatorTime timeField;

    private ClinicalDocumentAuthenticatorSignatureCode signatureCodeField;

    private ClinicalDocumentAuthenticatorAssignedEntity assignedEntityField;

    /// <remarks/>
    public ClinicalDocumentAuthenticatorTime time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorSignatureCode signatureCode
    {
      get
      {
        return this.signatureCodeField;
      }
      set
      {
        this.signatureCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorTime
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorSignatureCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntity
  {

    private ClinicalDocumentAuthenticatorAssignedEntityID idField;

    private ClinicalDocumentAuthenticatorAssignedEntityAddr addrField;

    private ClinicalDocumentAuthenticatorAssignedEntityTelecom telecomField;

    private ClinicalDocumentAuthenticatorAssignedEntityAssignedPerson assignedPersonField;

    private ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganization representedOrganizationField;

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganization representedOrganization
    {
      get
      {
        return this.representedOrganizationField;
      }
      set
      {
        this.representedOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityAssignedPerson
  {

    private ClinicalDocumentAuthenticatorAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityAssignedPersonName
  {

    private string givenField;

    private string familyField;

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganization
  {

    private ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationTelecom telecomField;

    private ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentAuthenticatorAssignedEntityRepresentedOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOf
  {

    private ClinicalDocumentDocumentationOfServiceEvent serviceEventField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEvent serviceEvent
    {
      get
      {
        return this.serviceEventField;
      }
      set
      {
        this.serviceEventField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEvent
  {

    private ClinicalDocumentDocumentationOfServiceEventEffectiveTime effectiveTimeField;

    private ClinicalDocumentDocumentationOfServiceEventPerformer performerField;

    private string classCodeField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformer performer
    {
      get
      {
        return this.performerField;
      }
      set
      {
        this.performerField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventEffectiveTime
  {

    private ClinicalDocumentDocumentationOfServiceEventEffectiveTimeLow lowField;

    private ClinicalDocumentDocumentationOfServiceEventEffectiveTimeHigh highField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventEffectiveTimeHigh high
    {
      get
      {
        return this.highField;
      }
      set
      {
        this.highField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventEffectiveTimeHigh
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformer
  {

    private ClinicalDocumentDocumentationOfServiceEventPerformerTemplateId templateIdField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerFunctionCode functionCodeField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerTime timeField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntity assignedEntityField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerFunctionCode functionCode
    {
      get
      {
        return this.functionCodeField;
      }
      set
      {
        this.functionCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerTime time
    {
      get
      {
        return this.timeField;
      }
      set
      {
        this.timeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerFunctionCode
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerTime
  {

    private ClinicalDocumentDocumentationOfServiceEventPerformerTimeLow lowField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerTimeHigh highField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerTimeHigh high
    {
      get
      {
        return this.highField;
      }
      set
      {
        this.highField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerTimeLow
  {

    private ulong valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerTimeHigh
  {

    private ulong valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntity
  {

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityID idField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityCode codeField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAddr addrField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityTelecom telecomField;

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAssignedPerson assignedPersonField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    private string countryField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    public string country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityTelecom
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAssignedPerson
  {

    private ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentDocumentationOfServiceEventPerformerAssignedEntityAssignedPersonName
  {

    private string givenField;

    private string familyField;

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponent
  {

    private ClinicalDocumentComponentComponent[] structuredBodyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("component", IsNullable = false)]
    public ClinicalDocumentComponentComponent[] structuredBody
    {
      get
      {
        return this.structuredBodyField;
      }
      set
      {
        this.structuredBodyField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponent
  {

    private ClinicalDocumentComponentComponentSection sectionField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSection section
    {
      get
      {
        return this.sectionField;
      }
      set
      {
        this.sectionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSection
  {

    private ClinicalDocumentComponentComponentSectionTemplateId[] templateIdField;

    private ClinicalDocumentComponentComponentSectionID idField;

    private ClinicalDocumentComponentComponentSectionCode codeField;

    private string titleField;

    private string textField;

    private ClinicalDocumentComponentComponentSectionEntry[] entryField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("templateId")]
    public ClinicalDocumentComponentComponentSectionTemplateId[] templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public string title
    {
      get
      {
        return this.titleField;
      }
      set
      {
        this.titleField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entry")]
    public ClinicalDocumentComponentComponentSectionEntry[] entry
    {
      get
      {
        return this.entryField;
      }
      set
      {
        this.entryField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionID
  {

    private decimal rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionText
  {

    private ClinicalDocumentComponentComponentSectionTextTable tableField;

    private ClinicalDocumentComponentComponentSectionTextParagraph[] paragraphField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionTextTable table
    {
      get
      {
        return this.tableField;
      }
      set
      {
        this.tableField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("paragraph")]
    public ClinicalDocumentComponentComponentSectionTextParagraph[] paragraph
    {
      get
      {
        return this.paragraphField;
      }
      set
      {
        this.paragraphField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionTextTable
  {

    private ClinicalDocumentComponentComponentSectionTextTableThead theadField;

    private ClinicalDocumentComponentComponentSectionTextTableTRTD[][] tbodyField;

    private byte borderField;

    private string widthField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionTextTableThead thead
    {
      get
      {
        return this.theadField;
      }
      set
      {
        this.theadField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("tr", IsNullable = false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("td", IsNullable = false, NestingLevel = 1)]
    public ClinicalDocumentComponentComponentSectionTextTableTRTD[][] tbody
    {
      get
      {
        return this.tbodyField;
      }
      set
      {
        this.tbodyField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte border
    {
      get
      {
        return this.borderField;
      }
      set
      {
        this.borderField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string width
    {
      get
      {
        return this.widthField;
      }
      set
      {
        this.widthField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionTextTableThead
  {

    private string[] trField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("th", IsNullable = false)]
    public string[] tr
    {
      get
      {
        return this.trField;
      }
      set
      {
        this.trField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionTextTableTRTD
  {

    private string[] listField;

    private ClinicalDocumentComponentComponentSectionTextTableTRTDContent contentField;

    private string[] textField;

    private byte colspanField;

    private bool colspanFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
    public string[] list
    {
      get
      {
        return this.listField;
      }
      set
      {
        this.listField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionTextTableTRTDContent content
    {
      get
      {
        return this.contentField;
      }
      set
      {
        this.contentField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte colspan
    {
      get
      {
        return this.colspanField;
      }
      set
      {
        this.colspanField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool colspanSpecified
    {
      get
      {
        return this.colspanFieldSpecified;
      }
      set
      {
        this.colspanFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionTextTableTRTDContent
  {

    private string idField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionTextParagraph
  {

    private string contentField;

    private string[] textField;

    /// <remarks/>
    public string content
    {
      get
      {
        return this.contentField;
      }
      set
      {
        this.contentField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntry
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounter encounterField;

    private ClinicalDocumentComponentComponentSectionEntryObservation observationField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizer organizerField;

    private ClinicalDocumentComponentComponentSectionEntryProcedure procedureField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministration substanceAdministrationField;

    private ClinicalDocumentComponentComponentSectionEntryAct actField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounter encounter
    {
      get
      {
        return this.encounterField;
      }
      set
      {
        this.encounterField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizer organizer
    {
      get
      {
        return this.organizerField;
      }
      set
      {
        this.organizerField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedure procedure
    {
      get
      {
        return this.procedureField;
      }
      set
      {
        this.procedureField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministration substanceAdministration
    {
      get
      {
        return this.substanceAdministrationField;
      }
      set
      {
        this.substanceAdministrationField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryAct act
    {
      get
      {
        return this.actField;
      }
      set
      {
        this.actField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounter
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterID idField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterText textField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformer performerField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipant participantField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationship[] entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformer performer
    {
      get
      {
        return this.performerField;
      }
      set
      {
        this.performerField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipant participant
    {
      get
      {
        return this.participantField;
      }
      set
      {
        this.participantField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entryRelationship")]
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationship[] entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterCode
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterCodeOriginalText originalTextField;

    private string nullFlavorField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterCodeOriginalText originalText
    {
      get
      {
        return this.originalTextField;
      }
      set
      {
        this.originalTextField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterCodeOriginalText
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterCodeOriginalTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterCodeOriginalTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterCodeOriginalTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterText
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeCenter centerField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeLow lowField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeHigh highField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeCenter center
    {
      get
      {
        return this.centerField;
      }
      set
      {
        this.centerField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeHigh high
    {
      get
      {
        return this.highField;
      }
      set
      {
        this.highField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeCenter
  {

    private ulong valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEffectiveTimeHigh
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformer
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntity assignedEntityField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntity
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityID idField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAddr addrField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityTelecom telecomField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAssignedPerson assignedPersonField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganization representedOrganizationField;

    private string classCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganization representedOrganization
    {
      get
      {
        return this.representedOrganizationField;
      }
      set
      {
        this.representedOrganizationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityID
  {

    private string extensionField;

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAddrCountry countryField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAddrCountry country
    {
      get
      {
        return this.countryField;
      }
      set
      {
        this.countryField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAddrCountry
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAssignedPerson
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityAssignedPersonName
  {

    private string familyField;

    private string[] givenField;

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("given")]
    public string[] given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganization
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationTelecom telecomField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterPerformerAssignedEntityRepresentedOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipant
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRole participantRoleField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRole participantRole
    {
      get
      {
        return this.participantRoleField;
      }
      set
      {
        this.participantRoleField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRole
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleID idField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleAddr addrField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleTelecom telecomField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRolePlayingEntity playingEntityField;

    private string classCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRolePlayingEntity playingEntity
    {
      get
      {
        return this.playingEntityField;
      }
      set
      {
        this.playingEntityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleID
  {

    private string extensionField;

    private decimal rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleCode
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRoleTelecom
  {

    private string useField;

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterParticipantParticipantRolePlayingEntity
  {

    private string nameField;

    private string classCodeField;

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipAct actField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservation observationField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipAct act
    {
      get
      {
        return this.actField;
      }
      set
      {
        this.actField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipAct
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationship entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationship entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservation observationField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservation
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationID idField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationValue valueField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationID
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationCode
  {

    private uint codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationEffectiveTimeLow lowField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationValue
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationValueTranslation translationField;

    private string nullFlavorField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationValueTranslation translation
    {
      get
      {
        return this.translationField;
      }
      set
      {
        this.translationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipActEntryRelationshipObservationValueTranslation
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservation
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationID idField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValue valueField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationID
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationCode
  {

    private uint codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationEffectiveTime
  {

    private uint valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValue
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValueOriginalText originalTextField;

    private string nullFlavorField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValueOriginalText originalText
    {
      get
      {
        return this.originalTextField;
      }
      set
      {
        this.originalTextField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValueOriginalText
  {

    private ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValueOriginalTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValueOriginalTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryEncounterEntryRelationshipObservationValueOriginalTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservation
  {

    private ClinicalDocumentComponentComponentSectionEntryObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryObservationID idField;

    private ClinicalDocumentComponentComponentSectionEntryObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryObservationText textField;

    private ClinicalDocumentComponentComponentSectionEntryObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryObservationValue valueField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationID
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationCode
  {

    private string nullFlavorField;

    private string codeField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationText
  {

    private ClinicalDocumentComponentComponentSectionEntryObservationTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTimeLow lowField;

    private ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTimeHigh highField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTimeHigh high
    {
      get
      {
        return this.highField;
      }
      set
      {
        this.highField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTimeLow
  {

    private string nullFlavorField;

    private string valueField;

    private bool valueFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationEffectiveTimeHigh
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryObservationValue
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizer
  {

    private ClinicalDocumentComponentComponentSectionEntryOrganizerTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerID idField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponent[] componentField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("component")]
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponent[] component
    {
      get
      {
        return this.componentField;
      }
      set
      {
        this.componentField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerID
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerCode
  {

    private string nullFlavorField;

    private string codeField;

    private bool codeFieldSpecified;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool codeSpecified
    {
      get
      {
        return this.codeFieldSpecified;
      }
      set
      {
        this.codeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerEffectiveTime
  {

    private string nullFlavorField;

    private uint valueField;

    private bool valueFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponent
  {

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservation observationField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservation
  {

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationID idField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationText textField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationValue valueField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationship entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationship entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationID
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationCode
  {

    private string codeField;

    private string codeSystemField;

    private string codeSystemNameField;

    private string displayNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationText
  {

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEffectiveTime
  {

    private string nullFlavorField;

    private uint valueField;

    private bool valueFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationValue
  {

    private string nullFlavorField;

    private string unitField;

    private string valueField;

    private bool valueFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit
    {
      get
      {
        return this.unitField;
      }
      set
      {
        this.unitField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipAct actField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipAct act
    {
      get
      {
        return this.actField;
      }
      set
      {
        this.actField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipAct
  {

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActID idField;

    private ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActCode codeField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActID
  {

    private string extensionField;

    private decimal rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryOrganizerComponentObservationEntryRelationshipActCode
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedure
  {

    private ClinicalDocumentComponentComponentSectionEntryProcedureTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureID idField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationship entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationship entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureCode
  {

    private ClinicalDocumentComponentComponentSectionEntryProcedureCodeOriginalText originalTextField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureCodeTranslation translationField;

    private string nullFlavorField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureCodeOriginalText originalText
    {
      get
      {
        return this.originalTextField;
      }
      set
      {
        this.originalTextField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureCodeTranslation translation
    {
      get
      {
        return this.translationField;
      }
      set
      {
        this.translationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureCodeOriginalText
  {

    private ClinicalDocumentComponentComponentSectionEntryProcedureCodeOriginalTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureCodeOriginalTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureCodeOriginalTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureCodeTranslation
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTimeLow lowField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTimeHigh highField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTimeHigh high
    {
      get
      {
        return this.highField;
      }
      set
      {
        this.highField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEffectiveTimeHigh
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounter encounterField;

    private string typeCodeField;

    private bool inversionIndField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounter encounter
    {
      get
      {
        return this.encounterField;
      }
      set
      {
        this.encounterField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool inversionInd
    {
      get
      {
        return this.inversionIndField;
      }
      set
      {
        this.inversionIndField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounter
  {

    private ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounterID idField;

    private ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounterCode codeField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounterID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounterCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounterID
  {

    private string extensionField;

    private decimal rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryProcedureEntryRelationshipEncounterCode
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministration
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationID idField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationText textField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTime[] effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationDoseQuantity doseQuantityField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationAdministrationUnitCode administrationUnitCodeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumable consumableField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformer performerField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformant informantField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationship[] entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    private bool negationIndField;

    private bool negationIndFieldSpecified;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("effectiveTime")]
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTime[] effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationDoseQuantity doseQuantity
    {
      get
      {
        return this.doseQuantityField;
      }
      set
      {
        this.doseQuantityField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationAdministrationUnitCode administrationUnitCode
    {
      get
      {
        return this.administrationUnitCodeField;
      }
      set
      {
        this.administrationUnitCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumable consumable
    {
      get
      {
        return this.consumableField;
      }
      set
      {
        this.consumableField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformer performer
    {
      get
      {
        return this.performerField;
      }
      set
      {
        this.performerField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformant informant
    {
      get
      {
        return this.informantField;
      }
      set
      {
        this.informantField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entryRelationship")]
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationship[] entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool negationInd
    {
      get
      {
        return this.negationIndField;
      }
      set
      {
        this.negationIndField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool negationIndSpecified
    {
      get
      {
        return this.negationIndFieldSpecified;
      }
      set
      {
        this.negationIndFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationID
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationCode
  {

    private string codeField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationText
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimePeriod periodField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimeLow lowField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimeHigh highField;

    private bool institutionSpecified1Field;

    private bool institutionSpecified1FieldSpecified;

    private string operatorField;

    private uint valueField;

    private bool valueFieldSpecified;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimePeriod period
    {
      get
      {
        return this.periodField;
      }
      set
      {
        this.periodField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimeHigh high
    {
      get
      {
        return this.highField;
      }
      set
      {
        this.highField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("institutionSpecified")]
    public bool institutionSpecified1
    {
      get
      {
        return this.institutionSpecified1Field;
      }
      set
      {
        this.institutionSpecified1Field = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool institutionSpecified1Specified
    {
      get
      {
        return this.institutionSpecified1FieldSpecified;
      }
      set
      {
        this.institutionSpecified1FieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @operator
    {
      get
      {
        return this.operatorField;
      }
      set
      {
        this.operatorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimePeriod
  {

    private byte valueField;

    private string unitField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit
    {
      get
      {
        return this.unitField;
      }
      set
      {
        this.unitField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEffectiveTimeHigh
  {

    private string nullFlavorField;

    private string valueField;

    private bool valueFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationDoseQuantity
  {

    private decimal valueField;

    private bool valueFieldSpecified;

    private string unitField;

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit
    {
      get
      {
        return this.unitField;
      }
      set
      {
        this.unitField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationAdministrationUnitCode
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumable
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProduct manufacturedProductField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProduct manufacturedProduct
    {
      get
      {
        return this.manufacturedProductField;
      }
      set
      {
        this.manufacturedProductField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProduct
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterial manufacturedMaterialField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturerOrganization manufacturerOrganizationField;

    private string classCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterial manufacturedMaterial
    {
      get
      {
        return this.manufacturedMaterialField;
      }
      set
      {
        this.manufacturedMaterialField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturerOrganization manufacturerOrganization
    {
      get
      {
        return this.manufacturerOrganizationField;
      }
      set
      {
        this.manufacturerOrganizationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterial
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCode codeField;

    private uint lotNumberTextField;

    private bool lotNumberTextFieldSpecified;

    private string nameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public uint lotNumberText
    {
      get
      {
        return this.lotNumberTextField;
      }
      set
      {
        this.lotNumberTextField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lotNumberTextSpecified
    {
      get
      {
        return this.lotNumberTextFieldSpecified;
      }
      set
      {
        this.lotNumberTextFieldSpecified = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCode
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeOriginalText originalTextField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeTranslation translationField;

    private uint codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeOriginalText originalText
    {
      get
      {
        return this.originalTextField;
      }
      set
      {
        this.originalTextField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeTranslation translation
    {
      get
      {
        return this.translationField;
      }
      set
      {
        this.translationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeOriginalText
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeOriginalTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeOriginalTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeOriginalTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturedMaterialCodeTranslation
  {

    private ulong codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationConsumableManufacturedProductManufacturerOrganization
  {

    private string nameField;

    private string classCodeField;

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformer
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntity assignedEntityField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntity
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityID idField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAddr addrField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityTelecom telecomField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAssignedPerson assignedPersonField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAddr
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityTelecom
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAssignedPerson
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationPerformerAssignedEntityAssignedPersonName
  {

    private string familyField;

    private string givenField;

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformant
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntity assignedEntityField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntity assignedEntity
    {
      get
      {
        return this.assignedEntityField;
      }
      set
      {
        this.assignedEntityField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntity
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityID idField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAddr addrField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityTelecom[] telecomField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAssignedPerson assignedPersonField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganization representedOrganizationField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("telecom")]
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityTelecom[] telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAssignedPerson assignedPerson
    {
      get
      {
        return this.assignedPersonField;
      }
      set
      {
        this.assignedPersonField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganization representedOrganization
    {
      get
      {
        return this.representedOrganizationField;
      }
      set
      {
        this.representedOrganizationField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityID
  {

    private string rootField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private uint postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public uint postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAssignedPerson
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAssignedPersonName nameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAssignedPersonName name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityAssignedPersonName
  {

    private string familyField;

    private string givenField;

    /// <remarks/>
    public string family
    {
      get
      {
        return this.familyField;
      }
      set
      {
        this.familyField = value;
      }
    }

    /// <remarks/>
    public string given
    {
      get
      {
        return this.givenField;
      }
      set
      {
        this.givenField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganization
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationID[] idField;

    private string nameField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationTelecom telecomField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationAddr addrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationID[] id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationTelecom telecom
    {
      get
      {
        return this.telecomField;
      }
      set
      {
        this.telecomField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationAddr addr
    {
      get
      {
        return this.addrField;
      }
      set
      {
        this.addrField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationID
  {

    private string rootField;

    private uint extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationTelecom
  {

    private string useField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string use
    {
      get
      {
        return this.useField;
      }
      set
      {
        this.useField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationInformantAssignedEntityRepresentedOrganizationAddr
  {

    private string streetAddressLineField;

    private string cityField;

    private string stateField;

    private string postalCodeField;

    /// <remarks/>
    public string streetAddressLine
    {
      get
      {
        return this.streetAddressLineField;
      }
      set
      {
        this.streetAddressLineField = value;
      }
    }

    /// <remarks/>
    public string city
    {
      get
      {
        return this.cityField;
      }
      set
      {
        this.cityField = value;
      }
    }

    /// <remarks/>
    public string state
    {
      get
      {
        return this.stateField;
      }
      set
      {
        this.stateField = value;
      }
    }

    /// <remarks/>
    public string postalCode
    {
      get
      {
        return this.postalCodeField;
      }
      set
      {
        this.postalCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservation observationField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipAct actField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipAct act
    {
      get
      {
        return this.actField;
      }
      set
      {
        this.actField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservation
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationValue valueField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipObservationValue
  {

    private string valueField;

    private bool valueFieldSpecified;

    private string codeField;

    private bool codeFieldSpecified;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueSpecified
    {
      get
      {
        return this.valueFieldSpecified;
      }
      set
      {
        this.valueFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool codeSpecified
    {
      get
      {
        return this.codeFieldSpecified;
      }
      set
      {
        this.codeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipAct
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActTemplateId[] templateIdField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActID idField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActCode codeField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActText textField;

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActStatusCode statusCodeField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("templateId")]
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActTemplateId[] templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActID
  {

    private string extensionField;

    private decimal rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActCode
  {

    private string nullFlavorField;

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActText
  {

    private ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntrySubstanceAdministrationEntryRelationshipActStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryAct
  {

    private ClinicalDocumentComponentComponentSectionEntryActTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryActID idField;

    private ClinicalDocumentComponentComponentSectionEntryActCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryActText textField;

    private ClinicalDocumentComponentComponentSectionEntryActStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryActEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationship entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationship entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActID
  {

    private string rootField;

    private string nullFlavorField;

    private string extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActCode
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActText
  {

    private ClinicalDocumentComponentComponentSectionEntryActTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActStatusCode
  {

    private string codeField;

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryActEffectiveTimeCenter centerField;

    private ClinicalDocumentComponentComponentSectionEntryActEffectiveTimeLow lowField;

    private string nullFlavorField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEffectiveTimeCenter center
    {
      get
      {
        return this.centerField;
      }
      set
      {
        this.centerField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEffectiveTimeCenter
  {

    private ulong valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ulong value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservation observationField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservation
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationID idField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationText textField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationValue valueField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipant participantField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationship[] entryRelationshipField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipant participant
    {
      get
      {
        return this.participantField;
      }
      set
      {
        this.participantField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entryRelationship")]
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationship[] entryRelationship
    {
      get
      {
        return this.entryRelationshipField;
      }
      set
      {
        this.entryRelationshipField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationID
  {

    private string rootField;

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationCode
  {

    private string codeField;

    private string codeSystemField;

    private string codeSystemNameField;

    private string displayNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationText
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEffectiveTimeLow lowField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationValue
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationValueTranslation translationField;

    private string codeField;

    private bool codeFieldSpecified;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    private string nullFlavorField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationValueTranslation translation
    {
      get
      {
        return this.translationField;
      }
      set
      {
        this.translationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool codeSpecified
    {
      get
      {
        return this.codeFieldSpecified;
      }
      set
      {
        this.codeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationValueTranslation
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipant
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRole participantRoleField;

    private string typeCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRole participantRole
    {
      get
      {
        return this.participantRoleField;
      }
      set
      {
        this.participantRoleField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRole
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntity playingEntityField;

    private string classCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntity playingEntity
    {
      get
      {
        return this.playingEntityField;
      }
      set
      {
        this.playingEntityField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntity
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCode codeField;

    private string nameField;

    private string classCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public string name
    {
      get
      {
        return this.nameField;
      }
      set
      {
        this.nameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCode
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeOriginalText originalTextField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeTranslation translationField;

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeOriginalText originalText
    {
      get
      {
        return this.originalTextField;
      }
      set
      {
        this.originalTextField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeTranslation translation
    {
      get
      {
        return this.translationField;
      }
      set
      {
        this.translationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeOriginalText
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeOriginalTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeOriginalTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeOriginalTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationParticipantParticipantRolePlayingEntityCodeTranslation
  {

    private string codeField;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationship
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipAct actField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservation observationField;

    private string typeCodeField;

    private bool inversionIndField;

    private bool inversionIndFieldSpecified;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipAct act
    {
      get
      {
        return this.actField;
      }
      set
      {
        this.actField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservation observation
    {
      get
      {
        return this.observationField;
      }
      set
      {
        this.observationField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string typeCode
    {
      get
      {
        return this.typeCodeField;
      }
      set
      {
        this.typeCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool inversionInd
    {
      get
      {
        return this.inversionIndField;
      }
      set
      {
        this.inversionIndField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool inversionIndSpecified
    {
      get
      {
        return this.inversionIndFieldSpecified;
      }
      set
      {
        this.inversionIndFieldSpecified = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipAct
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActID idField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActCode codeField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActID
  {

    private string extensionField;

    private decimal rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension
    {
      get
      {
        return this.extensionField;
      }
      set
      {
        this.extensionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipActCode
  {

    private string nullFlavorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservation
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationTemplateId templateIdField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationID idField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationCode codeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationText textField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationStatusCode statusCodeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationEffectiveTime effectiveTimeField;

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValue valueField;

    private string classCodeField;

    private string moodCodeField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationTemplateId templateId
    {
      get
      {
        return this.templateIdField;
      }
      set
      {
        this.templateIdField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationID id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationCode code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationText text
    {
      get
      {
        return this.textField;
      }
      set
      {
        this.textField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationStatusCode statusCode
    {
      get
      {
        return this.statusCodeField;
      }
      set
      {
        this.statusCodeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationEffectiveTime effectiveTime
    {
      get
      {
        return this.effectiveTimeField;
      }
      set
      {
        this.effectiveTimeField = value;
      }
    }

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValue value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string classCode
    {
      get
      {
        return this.classCodeField;
      }
      set
      {
        this.classCodeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moodCode
    {
      get
      {
        return this.moodCodeField;
      }
      set
      {
        this.moodCodeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationTemplateId
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationID
  {

    private string rootField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string root
    {
      get
      {
        return this.rootField;
      }
      set
      {
        this.rootField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationCode
  {

    private string codeField;

    private string codeSystemField;

    private string codeSystemNameField;

    private string displayNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationText
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationStatusCode
  {

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationEffectiveTime
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationEffectiveTimeLow lowField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationEffectiveTimeLow low
    {
      get
      {
        return this.lowField;
      }
      set
      {
        this.lowField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationEffectiveTimeLow
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValue
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValueOriginalText originalTextField;

    private string nullFlavorField;

    private string codeField;

    private bool codeFieldSpecified;

    private string displayNameField;

    private string codeSystemField;

    private string codeSystemNameField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValueOriginalText originalText
    {
      get
      {
        return this.originalTextField;
      }
      set
      {
        this.originalTextField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nullFlavor
    {
      get
      {
        return this.nullFlavorField;
      }
      set
      {
        this.nullFlavorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
      get
      {
        return this.codeField;
      }
      set
      {
        this.codeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool codeSpecified
    {
      get
      {
        return this.codeFieldSpecified;
      }
      set
      {
        this.codeFieldSpecified = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName
    {
      get
      {
        return this.displayNameField;
      }
      set
      {
        this.displayNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystem
    {
      get
      {
        return this.codeSystemField;
      }
      set
      {
        this.codeSystemField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName
    {
      get
      {
        return this.codeSystemNameField;
      }
      set
      {
        this.codeSystemNameField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValueOriginalText
  {

    private ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValueOriginalTextReference referenceField;

    /// <remarks/>
    public ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValueOriginalTextReference reference
    {
      get
      {
        return this.referenceField;
      }
      set
      {
        this.referenceField = value;
      }
    }
  }

  /// <remarks/>
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
  public partial class ClinicalDocumentComponentComponentSectionEntryActEntryRelationshipObservationEntryRelationshipObservationValueOriginalTextReference
  {

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value
    {
      get
      {
        return this.valueField;
      }
      set
      {
        this.valueField = value;
      }
    }

  }
}
