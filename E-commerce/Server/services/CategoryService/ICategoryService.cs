using E_commerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Server.services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
