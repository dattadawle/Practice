using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_ApiExample.Models;

namespace Web_ApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), 200)]

        public IActionResult GetAll()
        {

            /*List<Category> categories = new List<Category>() {
            new Category {Id=1,Name="Cat1",Description="Desc1"},
            new Category {Id=2,Name="Cat2",Description="Desc2"},
            new Category {Id=2,Name="Cat3",Description="Desc3"}

            };*/
            //var categories= _context.Categories; => return DbSet not collection of data
            // so need to convert in list 
            var categories = _context.Categories.ToList();

            return Ok(categories);
        }
        [HttpGet("Category/{id:int}")]
        [ProducesResponseType(200,Type =typeof(Category))]
        [ProducesErrorResponseType(typeof(BadRequest))]
        public IActionResult GetById(int id)
        {
            if (id > 0)
            {
                /*Category category = new Category();
                category = new Category { Id = 1, Name = "cat1", Description = "Desc1" };*/
                
                    var category = _context.Categories.Find(id);
                    return Ok(category);
                
                
            }
            return BadRequest();
        }

        [HttpPost]
        [ProducesResponseType(201,Type=typeof(Category))]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return Created();
            }
              return BadRequest();
           
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesErrorResponseType(typeof(BadRequest))]
        public IActionResult Update(Category category,int id)
        {
            if(id==category.Id)
            {
                if (ModelState.IsValid)
                {
                    _context.Categories.Attach(category);
                    _context.Entry(category).State =EntityState.Modified;
                    _context.SaveChanges();
                    return Ok(category);
                }
            }

            return Ok();
        }

        [HttpDelete]

        [ProducesResponseType(200)]
        [ProducesErrorResponseType(typeof(BadRequest))]
        public IActionResult Delete(int id)

        {
            if (id > 0)
            {
                
              Category category= _context.Categories.Find(id);
                _context.Remove(category);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

    }
}
