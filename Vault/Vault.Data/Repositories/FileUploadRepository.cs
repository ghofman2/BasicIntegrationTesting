using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vault.Data.Interfaces;
using Vault.Data.Models;

namespace Vault.Data.Repositories
{
  public class FileUploadRepository : IFileUploadRepository
  {
    private VaultContext _db;

    public FileUploadRepository(VaultContext db)
    {
      _db = db;
    }
    public FileUpload Get(int id)
    {
      return _db.FileUploads.Single(x => x.Id == id);
    }

    public FileUpload Save(FileUpload entity)
    {
      if (entity.Id == 0)
      {
        //new entry
        _db.FileUploads.Add(entity);
      }
      else
      {
        //existing entry
        _db.FileUploads.Attach(entity);
        _db.Entry(entity).State = EntityState.Modified;
      }

      _db.SaveChanges();

      return entity;
    }
  }
}
