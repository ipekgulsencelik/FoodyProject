using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    internal class SocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
    {
        public SocialMediaDAL(FoodyContext context) : base(context)
        {
        }
    }
}