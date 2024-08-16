using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class ProductDAL : GenericRepository<Product>, IProductDAL
    {
        public ProductDAL(FoodyContext context) : base(context)
        {
        }
    }
}