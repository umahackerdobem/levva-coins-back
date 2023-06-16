using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDto category)
        {
            var categoryCreated = _service.Create(category);
            return Created("", categoryCreated);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryDto> Get(int id)
        {
            return _service.Get(id);
        }

        
        [HttpGet]
        public ActionResult<List<CategoryDto>> GetAll()
        {
            return _service.GetAll();
        }


        [HttpPut]
        public IActionResult Update(CategoryDto category)
        {
            _service.Update(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
