using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class FeatureDAL : GenericRepository<Feature>, IFeatureDAL
    {
        public FeatureDAL(FoodyContext context) : base(context)
        {
        }

        public List<Feature> FeatureListByStatusTrue()
        {
            var context = new FoodyContext();
            var values = context.Features.Where(x => x.Status == true).ToList();
            return values;
        }
    }
}