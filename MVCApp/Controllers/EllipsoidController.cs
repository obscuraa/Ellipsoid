using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class EllipsoidController : Controller
    {
        private static List<EllipsoidViewModel> _ellipsoidModels = new List<EllipsoidViewModel>();

        public IActionResult Index()
        {
            return View(_ellipsoidModels);
        }

        public IActionResult Create()
        {
            var model = new EllipsoidViewModel();
            return View(model);
        }

        public IActionResult CreateEllipsoid(EllipsoidViewModel ellipsoid)
        {
            //return View("Index");
            ellipsoid.NC = Math.Pow(ellipsoid.R_i, 3) / Math.Pow(ellipsoid.Radius, 3);
            _ellipsoidModels.Add(ellipsoid);
            return RedirectToAction(nameof(Index));
        }
    }
}