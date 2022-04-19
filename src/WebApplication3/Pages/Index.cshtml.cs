using DataProvider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        public Person person { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonRepository personProvider;

        public IndexModel(ILogger<IndexModel> logger, IPersonRepository personRepository)
        {
            personProvider = personRepository;
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(Person person)
        {
            var newPerson = personProvider.Create(person.FirstName, person.LastName, person.Age);
            return Redirect("/detail/" + newPerson.PersonId);
        }

    }
}
