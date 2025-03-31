using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Dummy authentication logic
            if (model.Email == "admin@example.com" && model.Password == "password123")
            {
                ViewData["Message"] = "Login successful!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
            }
        }
        return View(model);
    }
}
