using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public void TDelete(int id)
        {
            _featureDAL.Delete(id);
        }

        public List<Feature> TFeatureListByStatusTrue()
        {
            return _featureDAL.FeatureListByStatusTrue();
        }

        public List<Feature> TGetAll()
        {
            return _featureDAL.GetAll();
        }

        public Feature TGetByID(int id)
        {
            return _featureDAL.GetByID(id);
        }

        public void TInsert(Feature entity)
        {
            _featureDAL.Insert(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureDAL.Update(entity);
        }
    }
}