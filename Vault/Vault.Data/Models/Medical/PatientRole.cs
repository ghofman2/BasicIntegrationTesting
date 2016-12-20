using Vault.Data.Models.MedicalField;

namespace Vault.Data.Models.Medical
{
  public class PatientRole
  {
    public PatientId[] PatientIds { get; set; }

    public Address Address { get; set; }

    public Telecom Telecom { get; set; }

    public Patient Patient { get; set; }

    public ProviderOrganization ProviderOrganization { get; set; }
  }
}