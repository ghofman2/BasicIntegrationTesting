using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.XmlModels
{
  public class PatientContainer
  {
    public Address Address { get; set; }

    public string TelephoneNumber { get; set; }

    public Patient Patient { get; set; }

    public Organization ProviderOrganization { get; set; }
  }
}
