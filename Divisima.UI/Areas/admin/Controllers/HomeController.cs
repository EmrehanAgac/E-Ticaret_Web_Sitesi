using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Divisima.UI.Areas.admin.Controllers
{
    [Area("admin"), Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous, Route("/admin/login")]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login(string userName, String password)
        {
            return View();
        }
    }
}
