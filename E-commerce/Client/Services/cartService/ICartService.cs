using E_commerce.Shared;

namespace E_commerce.Client.Services.cartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem item);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item );
        Task EmptyCart();
    }
}
