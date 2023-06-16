using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//sistemi saldirilara karsi koruyan bir attribute
        public IActionResult Apply([FromForm]Candidate model)
        {
            return View();
        }
    }
        
    
}