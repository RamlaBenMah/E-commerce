using Blazored.LocalStorage;
using Blazored.Toast.Services;
using E_commerce.Client.Services.ProductService;
using E_commerce.Shared;
using System.Runtime.InteropServices;

namespace E_commerce.Client.Services.cartService
{
    public class CartService : ICartService
    {
        private readonly IProductService _productService ;
        private readonly IToastService _toastService ;
        private readonly ILocalStorageService _localStorage ;
        public event Action OnChange;
        public CartService(
            ILocalStorageService localStorage , 
            IToastService toastService , 
            IProductService productService) 
        {
            _productService = productService ;
            _toastService = toastService ;
            _localStorage = localStorage ;


        }

        public  async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart= new List<CartItem>();
            }
            var SameItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            if( SameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                SameItem.Quantity += item.Quantity;
            }
           
            await _localStorage.SetItemAsync("cart",cart);
                var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title, null);
            
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            
            var Cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (Cart == null)
            {
                return new List<CartItem>();
            }
           
            return Cart;
        }

        public  async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null) { return; }
            var CartItem= cart.Find(x=>x.ProductId==item.ProductId && x.EditionId== item.EditionId);
            cart.Remove(CartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }
    }
}
