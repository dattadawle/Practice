using Microsoft.AspNetCore.Mvc;

namespace Country_Task.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
