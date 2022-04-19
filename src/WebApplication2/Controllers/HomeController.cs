using DataProvider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonRepository _dataProvider;

        public HomeController(ILogger<HomeController> logger, IPersonRepository personRepository)
        {
            _logger = logger;
            _dataProvider = personRepository;

        }

        public IActionResult Index()
        {
            return View(_dataProvider.GetAll());
        }

        public IActionResult Detail(Guid id)
        {
            return View(_dataProvider.Get(id));
        }

        public IActionResult Update(Person person)
        {
            _dataProvider.Update(person.PersonId, person.FirstName, person.LastName, person.Age);
            return RedirectToAction("Detail", new { id = person.PersonId });
        }

        public IActionResult Delete(Guid id)
        {
            _dataProvider.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create(string firstName, string lastName, int age)
        {
            var newPerson = _dataProvider.Create(firstName, lastName, age);
            return RedirectToAction("Detail", new { id = newPerson.PersonId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
