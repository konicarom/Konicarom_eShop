using eShop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUseCase
    {
        Task<Order> Excute(int productId, int quantity);
    }
}