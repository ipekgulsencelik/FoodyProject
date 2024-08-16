using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;

namespace Foody.BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDAL _sliderDAL;

        public SliderManager(ISliderDAL sliderDAL)
        {
            _sliderDAL = sliderDAL;
        }

        public void TDelete(int id)
        {
            _sliderDAL.Delete(id);
        }

        public List<Slider> TGetAll()
        {
            return _sliderDAL.GetAll();
        }

        public Slider TGetByID(int id)
        {
            return _sliderDAL.GetByID(id);
        }

        public void TInsert(Slider entity)
        {
            _sliderDAL.Insert(entity);
        }

        public void TUpdate(Slider entity)
        {
            _sliderDAL.Update(entity);
        }
    }
}