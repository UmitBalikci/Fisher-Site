using FisherSite.Management.Application.Abstracts;
using FisherSite.Management.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FisherSite.Management.Presentation.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IApartmentService _apartmentService;
        private readonly IPersonService _personService;
        private readonly IApartmentStateService _apartmentStateService;
        private readonly IApartmentTypeService _apartmentTypeService;
        private readonly IBlockService _blockService;
        public ApartmentController(
            IApartmentService apartmentService,
            IPersonService personService,
            IApartmentStateService apartmentStateService,
            IApartmentTypeService apartmentTypeService,
            IBlockService blockService)
        {
            _apartmentService = apartmentService;
            _personService = personService;
            _apartmentStateService = apartmentStateService;
            _apartmentTypeService = apartmentTypeService;
            _blockService = blockService;
        }
        public IActionResult Index()
        {
            var persons = _personService.GetAll();
            var apartments = _apartmentService.GetAll();
            var apartmentStates = _apartmentStateService.GetAll();
            var apartmentTypes= _apartmentTypeService.GetAll();
            var blocks = _blockService.GetAll();
            ViewBag.Persons = persons;
            ViewBag.ApartmentStates = apartmentStates;
            ViewBag.ApartmentTypes = apartmentTypes;
            ViewBag.Blocks = blocks;
            return View(apartments);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ApartmentDTO apartmentDTO)
        {
            if (apartmentDTO != null)
            {
                _apartmentService.Create(apartmentDTO);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Update(int id)
        {
            var apartment = _apartmentService.GetById(id);
            if (apartment != null)
            {
                return View(apartment);
            }
            return Content("Bu Id'ye ait kayıt bulunamadı!");
        }
        [HttpPost]
        public IActionResult Update(ApartmentDTO apartmentDTO)
        {
            if (apartmentDTO != null)
            {
                _apartmentService.Update(apartmentDTO);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Apartment = "Alanları boş gönderemezsiniz";
                return View();
            }
            
        }
        public IActionResult Delete(ApartmentDTO apartmentDTO)
        {
            _apartmentService.Delete(apartmentDTO);
            return RedirectToAction("Index");
        }

    }
}
