using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repository;
using Foody.EntityLayer.Concrete;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class SliderDAL : GenericRepository<Slider>, ISliderDAL
    {
        public SliderDAL(FoodyContext context) : base(context)
        {
        }
    }
}