using E_commerce.Server.services.ProductService;
using Microsoft.AspNetCore.Mvc;

using E_commerce.Shared;
namespace E_commerce.Server.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IproductService _productService;
        public ProductController(IproductService productService)
        {
             _productService=productService;
        }
        [HttpGet]
        public async  Task <ActionResult<List<Product>>>GetAllProducts()
        {
            return Ok (await _productService.GetAllProducts());
        }
        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProduct(int id )
        {
            return Ok(await _productService.GetProduct(id));
        }
        [HttpGet("Search/{searchText}")]
        public async Task<ActionResult<List<Product>>> SearchProducts(string searchText)
        {
            return Ok(await _productService.SearchProducts(searchText));
        }
    }
}
