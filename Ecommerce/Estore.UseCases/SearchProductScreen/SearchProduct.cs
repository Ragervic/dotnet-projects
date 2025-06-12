using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estore.CoreBusiness.Models;
using Estore.CoreBusiness.PluginInterfaces.DataStore;

namespace Estore.UseCases.SearchProductScreen
{
    public class SearchProduct
    {
        private readonly IProductRepository productRepository;

        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> Execute(string filter)
        {
            return productRepository.GetProducts(filter);
        }
    }
}
