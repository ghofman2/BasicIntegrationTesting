using System.Collections.Generic;
using Vault.Data.Models.Base;

namespace Vault.Data.Models
{
  public class Folder : Entity
  {
    public string Name { get; set; }

    public int CabinetId { get; set; }

    public virtual Cabinet Cabinet { get; set; }

    public virtual ICollection<File> Files { get; set; }
  }
}
