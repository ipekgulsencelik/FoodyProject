using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    public class AboutItemManager : IAboutItemService
    {
        private readonly IAboutItemDAL _aboutItemDAL;

        public AboutItemManager(IAboutItemDAL aboutItemDAL)
        {
            _aboutItemDAL = aboutItemDAL;
        }
        
        public void TDelete(int id)
        {
            _aboutItemDAL.Delete(id);
        }
        
        public List<AboutItem> TGetAll()
        {
            return _aboutItemDAL.GetAll();
        }
        
        public AboutItem TGetByID(int id)
        {
            return _aboutItemDAL.GetByID(id);
        }

        public void TInsert(AboutItem entity)
        {
            _aboutItemDAL.Insert(entity);
        }
        
        public void TUpdate(AboutItem entity)
        {
            _aboutItemDAL.Update(entity);
        }
    }
}