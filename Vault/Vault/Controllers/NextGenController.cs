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
using CommonLibrary;

namespace Vault.Controllers
{
  public class NextGenController : Controller
  {

    //private ICabinetRepository _cabinetRepo;

    //[Inject]
    //public NextGenController(ICabinetRepository cabinetRepo)
    //{
    //  _cabinetRepo = cabinetRepo;
    //}

    #region Controller Actions
    public ActionResult Index()
    {
      //var cabinets = _cabinetRepo.GetAll();

      //var cabinetModels = Mapper.Map<List<Cabinet>, List<CabinetModel>>(cabinets);

      return View("Index", "NextGen");
    }
    #endregion
  }
}