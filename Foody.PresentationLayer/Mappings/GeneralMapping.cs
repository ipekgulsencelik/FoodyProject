using AutoMapper;
using Foody.DTO.DTOs.AboutDTOs;
using Foody.DTO.DTOs.SliderDTOs;
using Foody.EntityLayer.Concrete;

namespace Foody.PresentationLayer.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<CreateAboutDTO, About>().ReverseMap();
            CreateMap<GetByIdAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();

            CreateMap<ResultSliderDTO, Slider>().ReverseMap();
            CreateMap<CreateSliderDTO, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDTO, Slider>().ReverseMap();
            CreateMap<UpdateSliderDTO, Slider>().ReverseMap();
        }
    }
}