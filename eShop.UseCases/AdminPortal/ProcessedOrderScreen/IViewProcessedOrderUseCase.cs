using eShop.CoreBusiness.Models;

namespace eShop.UseCases.AdminPortal.ProcessedOrderScreen
{
    public interface IViewProcessedOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}