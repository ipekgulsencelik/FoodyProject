using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    internal class ReviewManager : IReviewService
    {
        private readonly IReviewDAL _reviewDAL;

        public ReviewManager(IReviewDAL reviewDAL)
        {
            _reviewDAL = reviewDAL;
        }

        public void TDelete(int id)
        {
            _reviewDAL.Delete(id);
        }

        public List<Review> TGetAll()
        {
            return _reviewDAL.GetAll();
        }

        public Review TGetByID(int id)
        {
            return _reviewDAL.GetByID(id);
        }

        public void TInsert(Review entity)
        {
            _reviewDAL.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
            _reviewDAL.Update(entity);
        }
    }
}