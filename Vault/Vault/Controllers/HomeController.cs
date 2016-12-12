using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Vault.Data.Interfaces;
using Vault.Data.Models;
using Vault.Data.ViewModels;

namespace Vault.Controllers
{
  public class HomeController : Controller
  {
    private ICabinetRepository _cabinetRepo;

    public HomeController(ICabinetRepository cabinetRepo)
    {
      _cabinetRepo = cabinetRepo;
    }

    public ActionResult Index()
    {
      var cabinets = _cabinetRepo.GetAll();

      var cabinetModels = Mapper.Map<List<Cabinet>, List<CabinetModel>>(cabinets);

      return View("Index", cabinetModels);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
