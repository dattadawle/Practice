using Microsoft.AspNetCore.Mvc;

namespace Country_Task.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
