using FisherSite.Management.Application.Abstracts;
using FisherSite.Management.Application.DTOs;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PersonDTO personDTO)
        {
            _personService.Create(personDTO);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var person = _personService.GetById(id);
            return View(person);
        }
        [HttpPost]
        public IActionResult Update(PersonDTO personDTO)
        {
            _personService.Update(personDTO);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(PersonDTO personDTO)
        {
            _personService.Delete(personDTO);
            return RedirectToAction("Index");
        }
    }
}
