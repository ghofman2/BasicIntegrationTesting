using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.XmlModels
{
  public class LegalAuthenticator
  {
    public Address Address { get; set; }

    public String TelephoneNumber { get; set; }

    public String FirstName { get; set; }

    public String LastName { get; set; }

    public Organization RepresentedOrganization { get; set; }
  }
}
