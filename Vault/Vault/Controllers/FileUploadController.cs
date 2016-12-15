using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vault.Data.Interfaces;
using Vault.Data.Models;

namespace Vault.Controllers
{
  public class FileUploadController : Controller
  {
    IFileUploadRepository _fileUploadRepo;

    [Inject]
    public FileUploadController(IFileUploadRepository fileUploadRepo)
    {
      _fileUploadRepo = fileUploadRepo;
    }

    [HttpPost]
    public ActionResult UploadFile(HttpPostedFileBase file)
    {
      FileUpload fileUpload = new FileUpload();
      fileUpload.FileName = file.FileName;
      fileUpload.Extension = Path.GetExtension(file.FileName);
      FileUpload dbFileUpload = _fileUploadRepo.Save(fileUpload);
      var storageLocation = getStorageLocation(dbFileUpload);
      file.SaveAs(Path.Combine(storageLocation, dbFileUpload.Id.ToString() + dbFileUpload.Extension));
      return RedirectToAction("Index", "Cabinet", null);
    }

    private String getStorageLocation(FileUpload fileUpload)
    {
      var fileId = fileUpload.Id;
      string fileNameFormat = "00000000.##";
      string fileName = fileId.ToString(fileNameFormat);
      string folderName = fileName.Remove(fileName.Length - 3) + "000";
      string storagePath = Path.Combine(@"D:\VaultStorage\", folderName);
      Directory.CreateDirectory(storagePath);
      return storagePath;
    }
  }

  
}