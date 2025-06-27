using E_commerce.Shared;
namespace E_commerce.Client.Services.ProductService

{
    public interface IProductService
     {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl )  ;
        Task<Product>GetProduct(int id );
        Task<List<Product>> SearchProducts(string searchText);

    }

}
