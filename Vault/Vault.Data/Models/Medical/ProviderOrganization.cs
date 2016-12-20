using Vault.Data.Models.MedicalField;

namespace Vault.Data.Models.Medical
{
  public class ProviderOrganization
  {
    public SharedIdModel Id { get; set; }

    public string Name { get; set; }

    public Telecom Telecom { get; set; }

    public Address Address { get; set; }
  }
}
