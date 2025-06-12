using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estore.CoreBusiness.Models;
using Estore.CoreBusiness.PluginInterfaces.DataStore;

namespace Estore.UseCases.SearchProductScreen
{
    public class ViewProduct
    {
        private readonly IProductRepository productRepository;
        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Execute(int id)
        {
            return productRepository.GetProduct(id);
        }
    }
}
