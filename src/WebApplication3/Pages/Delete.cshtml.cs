using DataProvider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApplication3.Pages
{
    public class DeleteModel : PageModel
    {
        private IPersonRepository personRepository;
        public DeleteModel(IPersonRepository dataProvider)
        {
            personRepository = dataProvider;
        }
        public IActionResult OnGet(Guid id)
        {
            personRepository.Delete(id);
            return Redirect("/index");
        }
    }
}
