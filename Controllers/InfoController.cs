using Microsoft.AspNetCore.Mvc;

namespace EduConnect.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult TermsOfService()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
