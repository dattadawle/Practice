using Microsoft.AspNetCore.Mvc;

namespace Country_Task.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
