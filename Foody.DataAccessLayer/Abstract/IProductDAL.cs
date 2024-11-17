using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.Abstract
{
    public interface IProductDAL : IGenericDAL<Product>
    {
        List<Product> ProductListWithCategory();
        List<Product> ProductListWithCategoryAndLast12Items();
    }
}