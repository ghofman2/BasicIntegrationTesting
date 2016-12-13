using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Vault.Data.Models;

namespace Vault.Data.Migrations
{
  internal sealed class Configuration : DbMigrationsConfiguration<VaultContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(VaultContext db)
    {
      ////How to debug the seed
      ////1. uncomment the if block below
      ////2. launch a new instance of VS and open this project
      ////3. place your breakpoint(s) in the new instance of VS
      ////4. run update-database in the package manager console in this instance of VS
      ////5. when prompted, select the other VS instance for debugging
      //if (!Debugger.IsAttached)
      //{
      //  Debugger.Launch();
      //}

      SeedCabinets(db);
    }

    private void SeedCabinets(VaultContext db)
    {
      try
      {
        var cabinetsExist = db.Cabinets.Any();

        if (!cabinetsExist)
        {
          //add a story with some characters so we have something to start with
          var cabinet = new Cabinet
          {
            Folders = new List<Folder>(),
            Name = "Test Seeded Cabinet!"
          };

          var folderOne = new Folder
          {
            Name = "Storage Folder One"
          };

          var folderTwo = new Folder
          {
            Name = "Storage Folder Two"
          };

          cabinet.Folders.Add(folderOne);
          cabinet.Folders.Add(folderTwo);

          db.Cabinets.Add(cabinet);

          db.SaveChanges();
        }
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
