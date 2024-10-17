using AutoMapper;
using Foody.BusinessLayer.Abstract;
using Foody.DTO.DTOs.AboutDTOs;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAboutService _aboutService;

        public AboutsController(IMapper mapper, IAboutService aboutService)
        {
            _mapper = mapper;
            _aboutService = aboutService;
        }

        public IActionResult AboutList()
        {
            var values = _aboutService.TGetAll();
            return View(_mapper.Map<List<ResultAboutDTO>>(values));
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDTO createAboutDTO)
        {
            var value = _mapper.Map<About>(createAboutDTO);
            _aboutService.TInsert(value);
            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return View(_mapper.Map<GetByIdAboutDTO>(value));
        }

        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDTO updateAboutDTO)
        {
            var value = _mapper.Map<About>(updateAboutDTO);
            _aboutService.TUpdate(value);
            return RedirectToAction("AboutList");
        }
    }
}