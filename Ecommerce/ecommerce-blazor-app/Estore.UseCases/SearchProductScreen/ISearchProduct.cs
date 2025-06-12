using Estore.CoreBusiness.Models;

namespace Estore.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter);
    }
}
