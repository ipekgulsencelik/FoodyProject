using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class ReviewDAL : GenericRepository<Review>, IReviewDAL
    {
        public ReviewDAL(FoodyContext context) : base(context)
        {
        }
    }
}