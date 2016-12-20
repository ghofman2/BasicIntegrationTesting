using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.Models.XmlModels
{
  public class AssignedEntity
  {
    public Address Address;

    public string OrganizationName;

    public AssignedPerson AssignedPerson { get; set; }
    
  }
}
