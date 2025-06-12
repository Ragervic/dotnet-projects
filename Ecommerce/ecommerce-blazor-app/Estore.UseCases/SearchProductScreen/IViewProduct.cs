using Estore.CoreBusiness.Models;

namespace Estore.UseCases.SearchProductScreen
{
    public interface IViewProduct
    {
        Product? Execute(int id);
    }
}
