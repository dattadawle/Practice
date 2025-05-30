using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Web_ApiExample.Models;

namespace Web_ApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {

            List<Category> categories = new List<Category>() {
            new Category {Id=1,Name="Cat1",Description="Desc1"},
            new Category {Id=2,Name="Cat2",Description="Desc2"},
            new Category {Id=2,Name="Cat3",Description="Desc3"}

            };

            return Ok(categories);
        }
        [HttpGet("Category/{id:int}")]
        [ProducesResponseType(200,Type =typeof(Category))]
        [ProducesErrorResponseType(typeof(BadRequest))]
        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                Category category = new Category();
                category = new Category { Id = 1, Name = "cat1", Description = "Desc1" };
                return Ok(category);
            }
            return BadRequest();
        }

        
    }
}
