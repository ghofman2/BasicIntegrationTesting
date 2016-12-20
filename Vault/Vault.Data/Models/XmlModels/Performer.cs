using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.XmlModels
{
  public class Performer
  {
    public String Time { get; set; }

    public Address Address { get; set; }

    public String TelephoneNumber { get; set; }

    public String AssignedPersonFirstName { get; set; }

    public String AssignedPersonLastName { get; set; }
  }
}
