using FisherSite.Management.Application.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FisherSite.Management.Presentation.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IApartmentService _apartmentService;
        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }
        public IActionResult Index()
        {
            var apartments = _apartmentService.GetAll();
            return View(apartments);
        }
    }
}
