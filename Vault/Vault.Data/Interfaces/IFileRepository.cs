using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Models;

namespace Vault.Data.Interfaces
{
  public interface IFileRepository
  {
    File Get(int id);

    File Save(File entity);
  }
}
