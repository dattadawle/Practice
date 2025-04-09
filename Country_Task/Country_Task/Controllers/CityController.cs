using Microsoft.AspNetCore.Mvc;

namespace Country_Task.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
