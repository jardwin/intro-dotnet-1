using DataProvider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace WebApplication3.Pages
{
    public class DetailModel : PageModel
    {
        public Person person;
        private readonly IPersonRepository _dataProvider;
        private readonly ILogger<DetailModel> _logger;

        public DetailModel(ILogger<DetailModel> logger, IPersonRepository dataProvider)
        {
            _dataProvider = dataProvider;
            _logger = logger;
        }

        public void OnGet(Guid id)
        {
            person = _dataProvider.Get(id);
        }

        public void OnPost(Person person)
        {
            _dataProvider.Update(person.PersonId, person.FirstName, person.LastName, person.Age);
            this.person = _dataProvider.Get(person.PersonId);
        }
    }
}
