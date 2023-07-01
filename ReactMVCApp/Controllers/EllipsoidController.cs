using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactMVCApp.Controllers
{
    public class EllipsoidController : Controller
    {
        // GET: EllipsoidController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EllipsoidController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EllipsoidController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EllipsoidController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EllipsoidController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EllipsoidController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EllipsoidController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EllipsoidController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
