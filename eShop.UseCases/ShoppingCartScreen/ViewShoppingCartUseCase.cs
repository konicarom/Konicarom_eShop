using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ShoppingCartScreenn.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreenn
{
    public class ViewShoppingCartUseCase : IViewShoppingCartUseCase
    {
        private readonly IShoppingCart shoppingCart;

        public ViewShoppingCartUseCase(IShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public Task<Order> Excute()
        {
            return shoppingCart.GetOrderAsync();
        }
    }
}
