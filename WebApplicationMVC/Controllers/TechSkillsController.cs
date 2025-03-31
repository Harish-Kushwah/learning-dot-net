using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class TechSkillsController : Controller
    {
        public IActionResult TechSkills()
        {
            return View();
        }
    }
}
