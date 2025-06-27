using E_commerce.Server.services.CategoryService;
using E_commerce.Server.Data;
using E_commerce.Shared;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Server.services.CategoryService

{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;
        public CategoryService(DataContext context)
        {
            _context= context;
        }

        public  async Task<List<Category>> GetCategories()
        {
               return await _context.Categories.ToListAsync();
        }

     
        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return  await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
