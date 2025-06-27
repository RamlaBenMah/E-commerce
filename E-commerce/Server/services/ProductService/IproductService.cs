using E_commerce.Shared;

namespace E_commerce.Server.services.ProductService
{
    public interface IproductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(String categoryUrl);
        Task<Product> GetProduct(int id);
        Task<List<Product>> SearchProducts(string searchText);
    }
}
