using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           
         List<Category>  categories1= _categoryService.GetAll().ToList();

            var categories= _mapper.Map<List<CategoryUi>>(categories1);
            return Ok(categories);
        }

        [HttpGet("/{id:int}")]
        public IActionResult Details(int id)
        {
            Category cat= _categoryService.GetById(id);
            var category= _mapper.Map<CategoryUi>(cat);
            return Ok(category);
        }

        [HttpPost]
        public ActionResult Create(CategoryUi categoryUi)
        {
            Category category = _mapper.Map<Category>(categoryUi);
            _categoryService.Create(category);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(CategoryUi categoryUi, int id)
            {
            if (ModelState.IsValid)
            {
                if(categoryUi.Id==id)
                {
                    var category = _mapper.Map<Category>(categoryUi);
                    _categoryService.Update(category);
                    return Ok();
                }
              return BadRequest();
            }
            return BadRequest();
            }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if(id>0)
            {
                var category = _categoryService.GetById(id);
                return Ok();
            }
            return BadRequest();
        }

    }
}
