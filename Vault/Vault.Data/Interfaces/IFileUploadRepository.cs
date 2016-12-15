using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models;

namespace Vault.Data.Interfaces
{
  public interface IFileUploadRepository
  {
    FileUpload Get(int id);

    FileUpload Save(FileUpload entity);
  }
}
