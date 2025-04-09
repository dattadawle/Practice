using Microsoft.AspNetCore.Mvc;

namespace Country_State_Web.Controllers
{
    public class CountryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
