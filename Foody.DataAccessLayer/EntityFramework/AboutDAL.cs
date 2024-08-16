using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class AboutDAL : GenericRepository<About>, IAboutDAL
    {
        public AboutDAL(FoodyContext context) : base(context)
        {
        }
    }
}