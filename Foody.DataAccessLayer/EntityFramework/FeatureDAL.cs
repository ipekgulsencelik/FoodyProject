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
    }
}