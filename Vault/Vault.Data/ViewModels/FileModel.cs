using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault.Data.ViewModels 
{
  public class FileModel : EntityModel
  {
    public string Name { get; set; }

    public int FoldertId { get; set; }

    public FolderModel Folder { get; set; }
  }
}
