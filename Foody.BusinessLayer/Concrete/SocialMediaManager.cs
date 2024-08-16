using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    internal class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _accountDAL;

        public SocialMediaManager(ISocialMediaDAL accountDAL)
        {
            _accountDAL = accountDAL;
        }

        public void TDelete(int id)
        {
            _accountDAL.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _accountDAL.GetAll();
        }

        public SocialMedia TGetByID(int id)
        {
            return _accountDAL.GetByID(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _accountDAL.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _accountDAL.Update(entity);
        }
    }
}