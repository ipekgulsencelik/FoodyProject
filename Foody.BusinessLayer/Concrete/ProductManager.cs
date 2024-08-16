using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    public class ProductManager : IAboutService
    {
        private readonly IAboutDAL _productDAL;

        public ProductManager(IAboutDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(int id)
        {
            _productDAL.Delete(id);
        }

        public List<About> TGetAll()
        {
            return _productDAL.GetAll();
        }

        public About TGetByID(int id)
        {
            return _productDAL.GetByID(id);
        }

        public void TInsert(About entity)
        {
            _productDAL.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _productDAL.Update(entity);
        }
    }
}