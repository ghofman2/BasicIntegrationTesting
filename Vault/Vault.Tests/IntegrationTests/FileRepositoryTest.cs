using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Vault.Data.Interfaces;
using Vault.Data.Models;
using Vault.Data.Repositories;
using Vault.Tests.Helpers;

namespace Vault.Tests.IntegrationTests
{
  [TestClass]
  public class FileRepositoryTest
  {

    IFileRepository _fileRepo;
    RepositoryHelper _repoHelper;

    public FileRepositoryTest()
    {
      _repoHelper = new RepositoryHelper();
      _fileRepo = new FileRepository(_repoHelper.Context);
    }

    [TestMethod]
    public void FileRepository_Get()
    {
      //seed a file
      var file = _repoHelper.SeedFiles().First();

      //get the file
      var fileDb = _fileRepo.Get(file.Id);

      //check to see if the db returns what we gave it
      var comparer = new PropertyComparer<File>();

      Assert.IsTrue(comparer.Equals(file, fileDb));
    }

    [TestMethod]
    public void FileRepository_Save()
    {
      //seed a file
      var file = _repoHelper.SeedFiles().First();

      //keep a local copy of the file name
      var folderInitName = file.Name;

      //modify the file
      file.Name = Guid.NewGuid().ToString();

      //keep a local copy of the new file name
      var fileModName = file.Name;

      //save the file with the new name
      _fileRepo.Save(file);

      //get the file from the db
      var fileDb = _fileRepo.Get(file.Id);

      //ensure the init name isn't the same as the db name
      Assert.AreNotEqual(folderInitName, fileDb.Name);

      //ensure the mod name is the same as the db name
      Assert.AreEqual(fileModName, fileDb.Name);

      //ensure the db returns what we gave it
      var comparer = new PropertyComparer<File>();

      Assert.IsTrue(comparer.Equals(file, fileDb));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "A File was saved without a Folder.")]
    public void FileRepository_NewNoFolder()
    {
      //create a folder
      var file = new File
      {
        Name = Guid.NewGuid().ToString(),
      };

      _fileRepo.Save(file);

    }

  }
}
