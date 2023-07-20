using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MVCApp.Models;

namespace MVCApp.Views.Ellipsoid
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public EllipsoidViewModel EllipsoidViewModel { get; set; }
        public double Conc { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Conc = Math.Pow(EllipsoidViewModel.R_i, 3) / Math.Pow(EllipsoidViewModel.Radius, 3);
            return RedirectToAction(nameof(Index));
        }
    }
}
