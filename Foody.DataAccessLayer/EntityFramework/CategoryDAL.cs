using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class CategoryDAL : GenericRepository<Category>, ICategoryDAL
    {
        public CategoryDAL(FoodyContext context) : base(context)
        {
        }
    }
}