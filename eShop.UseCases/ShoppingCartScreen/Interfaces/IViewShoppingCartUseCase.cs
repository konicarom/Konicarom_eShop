using eShop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreenn.Interfaces
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Excute();
    }
}