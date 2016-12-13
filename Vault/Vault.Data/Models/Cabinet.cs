using System.Collections.Generic;
using Vault.Data.Models.Base;

namespace Vault.Data.Models
{
  public class Cabinet : Entity
  {
    public string Name { get; set; }

    public string IsDeleted { get; set; }

    public virtual ICollection<Folder> Folders { get; set; }

    public virtual ICollection<CustomField> CustomFields { get; set; }
  }
}
