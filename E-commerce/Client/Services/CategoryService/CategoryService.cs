using E_commerce.Shared;
using System.Net.Http.Json;

namespace E_commerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
{
        private readonly HttpClient _http;
    public List<Category> categories { get ; set ; } = new List<Category> ();
     
     public CategoryService(HttpClient http) {
            _http = http;
        }
   public async Task Loadcategories()
    {
            categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
    }
}
}
