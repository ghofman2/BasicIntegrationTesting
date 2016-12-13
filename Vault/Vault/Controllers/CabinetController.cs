using AutoMapper;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vault.Data.Interfaces;
using Vault.Data.Models;
using Vault.Data.ViewModels;

namespace Vault.Controllers
{
  public class CabinetController : Controller
  {

    private ICabinetRepository _cabinetRepo;

    [Inject]
    public CabinetController(ICabinetRepository cabinetRepo)
    {
      _cabinetRepo = cabinetRepo;
    }

    #region Controller Actions
    [HttpGet]
    public ActionResult Index()
    {
      var cabinets = _cabinetRepo.GetAll();

      var cabinetModels = Mapper.Map<List<Cabinet>, List<CabinetModel>>(cabinets);

      return View("Index", cabinetModels);
    }

    [HttpGet]
    public ActionResult Create()
    {
      var cabinetModel = new CabinetModel();
      return View("Create", cabinetModel);
    }
    
    public ActionResult GenerateCustomField(int fieldNumber)
    {
      var customFieldModel = new CustomField
      {
        FieldNumber = fieldNumber
      };
      return PartialView("_CustomFields", customFieldModel);
    }

    [HttpPost]
    public ActionResult Create(String cabinetName, IEnumerable<CustomField> customFields)
    {
      Cabinet cabinet = new Cabinet() { Name = cabinetName, CustomFields = customFields.ToList() };
      _cabinetRepo.Save(cabinet);

      List<Cabinet> cabinets = _cabinetRepo.GetAll();
      List<CabinetModel> cabinetModels = Mapper.Map<List<Cabinet>, List<CabinetModel>>(cabinets);
      return View("Index", cabinetModels);
    }
    #endregion
  }
}