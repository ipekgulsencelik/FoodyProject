using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.EntityFramework;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(int id)
        {
            _productDAL.Delete(id);
        }

        public List<Product> TGetAll()
        {
            return _productDAL.GetAll();
        }

        public Product TGetByID(int id)
        {
            return _productDAL.GetByID(id);
        }

        public void TInsert(Product entity)
        {
            _productDAL.Insert(entity);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDAL.ProductListWithCategory();
        }

        public List<Product> TProductListWithCategoryAndLast12Items()
        {
            return _productDAL.ProductListWithCategoryAndLast12Items();
        }

        public void TUpdate(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}