using E_commerce.Server.services.CategoryService;
using E_commerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryservice;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryservice= categoryService;
        }

        [HttpGet]
        public  async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryservice.GetCategories());
        }
    }
}
