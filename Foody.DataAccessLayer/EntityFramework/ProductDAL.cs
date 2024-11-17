using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class ProductDAL : GenericRepository<Product>, IProductDAL
    {
        private readonly FoodyContext _context;
        
        public ProductDAL(FoodyContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public List<Product> ProductListWithCategoryAndLast12Items()
        {
            var values = _context.Products.OrderByDescending(x => x.ProductID).Take(12).Include(y => y.Category).ToList();
            return values;
        }
    }
}