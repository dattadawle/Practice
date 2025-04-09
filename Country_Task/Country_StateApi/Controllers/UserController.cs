using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Country_StateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        ApplicationDbContext _context;

        public UserController(ApplicationDbContext context) {

            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>>Index()
        {
            //    var Users= await _context.Users.Include(x => x.Country)
            //        .Include(x => x.State).Include(x => x.City).ToListAsync();
            //    return Ok(Users);



            var users = await _context.Users
                .Include(u => u.Country)
                .Include(u => u.State)
                .Include(u => u.City).ToListAsync();

            users.Select(u => new UserCopyRequirdData
            {
                Id = u.Id,
                FullName = u.Name,
                Email = u.Email,
                CountryName = u.Country.Name,
                StateName = u.State.Name,
                CityName = u.City.Name,
                Address = u.Address
            }).ToList();
      

            return Ok(users);
    }
    }
}
