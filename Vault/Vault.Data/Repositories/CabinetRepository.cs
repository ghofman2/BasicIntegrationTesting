using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vault.Data.Interfaces;
using Vault.Data.Models;

namespace Vault.Data.Repositories
{
  public class CabinetRepository : ICabinetRepository
  {
    private VaultContext _db;

    public CabinetRepository(VaultContext db)
    {
      _db = db;
    }

    public Cabinet Get(int id)
    {
      var cabinet = _db.Cabinets
        .Include(x => x.Folders)
        .Include(x => x.CustomFields)
        .Single(x => x.Id == id);

      return cabinet;
    }

    public List<Cabinet> GetAll()
    {
      return _db.Cabinets
        .Include(x => x.Folders)
        .Include(x => x.CustomFields)
        .AsNoTracking()
        .ToList();
    }

    public Cabinet Save(Cabinet entity)
    {
      if (entity.Id == 0)
      {
        //new entry
        _db.Cabinets.Add(entity);
      }
      else
      {
        //existing entry
        _db.Cabinets.Attach(entity);
        _db.Entry(entity).State = EntityState.Modified;
      }

      _db.SaveChanges();

      return entity;
    }
  }
}
