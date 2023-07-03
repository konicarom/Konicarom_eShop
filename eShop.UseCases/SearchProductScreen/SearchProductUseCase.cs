using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProductUseCase: ISearchProductUseCase
    {
        private readonly IProductRepository productRepository;
        public SearchProductUseCase(IProductRepository procductRepository) {
            this.productRepository = procductRepository;
        }
        public IEnumerable<Product> Execute(string filter)
        {
            return productRepository.GetProducts(filter);
        }
    }
}
