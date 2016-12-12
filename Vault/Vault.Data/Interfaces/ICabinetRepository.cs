using System.Collections.Generic;
using Vault.Data.Models;

namespace Vault.Data.Interfaces
{
  public interface ICabinetRepository
  {
    Cabinet Get(int id);

    List<Cabinet> GetAll();

    Cabinet Save(Cabinet entity);
  }
}
