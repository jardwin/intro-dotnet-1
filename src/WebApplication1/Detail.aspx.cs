using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataProvider;

namespace WebApplication1
{
    public partial class Detail : Page
    {
        private IPersonRepository personRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            personRepository = new PersonRepository();
        }

        public IEnumerable<Person> GetAllPerson() => personRepository.GetAll();
    }
}