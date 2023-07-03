using eShop.CoreBusiness.Models;

namespace eShop.UseCases.OrderConfirmationScreen
{
    public interface IViewOrderConfirmationUseCase
    {
        Order Excute(string uniqueId);
    }
}