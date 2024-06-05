using Microsoft.AspNetCore.Mvc;

namespace Divisima.UI.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
    }
}
