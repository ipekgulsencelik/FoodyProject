using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class AboutItemDAL : GenericRepository<AboutItem>, IAboutItemDAL
    {
        public AboutItemDAL(FoodyContext context) : base(context)
        {
        }
    }
}