using E_commerce.Shared;

namespace E_commerce.Client.Services.CategoryService
{
    public interface ICategoryService
{
    List<Category> categories { get; set; }
    Task Loadcategories();
}
}
