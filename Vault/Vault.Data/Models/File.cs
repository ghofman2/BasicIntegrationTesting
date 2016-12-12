using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models.Base;

namespace Vault.Data.Models
{
  public class File : Entity
  {
    public String Name { get; set; }

    public int FolderId { get; set; }

    public virtual Folder Folder { get; set; }

    public String Extension { get; set; }

    public DateTime DeletedDate { get; set; }

    public DateTime CreationDate { get; set; }

    public int Pages { get; set; }
  }
}
