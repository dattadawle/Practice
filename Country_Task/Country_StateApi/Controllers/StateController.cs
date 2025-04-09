using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Country_StateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        ApplicationDbContext _context;
        public StateController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<State>>> GetAll(int CountryId)
        {
            var states = await _context.States.Where(s=>s.CountryId==CountryId).ToListAsync();
            return Ok(states);
        }
    }
}
