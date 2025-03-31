using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
