using Vault.Data.Models;

namespace Vault.Data.Interfaces
{
  public interface IFolderRepository
  {
    Folder Get(int id);

    Folder Save(Folder entity);
  }
}
