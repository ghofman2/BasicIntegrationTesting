using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.XmlModels
{
  public class Custodian
  {
    public String Name { get; set; }

    public String TelephoneNumber { get; set; }

    public Address Address { get; set; }
  }
}
