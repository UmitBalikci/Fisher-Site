using FisherSite.Management.Application.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FisherSite.Management.Presentation.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        public IActionResult Index()
        {
            var persons = _personService.GetAll();
            return View(persons);
        }
    }
}
