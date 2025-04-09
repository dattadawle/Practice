using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Country_StateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CityController : ControllerBase
    {
        ApplicationDbContext _context;
        public CityController(ApplicationDbContext context) 
        { 
          _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetAll(int StateId )
        {
           var cities= await _context.Cities.Where(s=> s.StateId == StateId).ToListAsync();
            return Ok(cities);
        }
    }
}
