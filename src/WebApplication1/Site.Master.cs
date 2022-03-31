﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataProvider;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        private IPersonRepository provider;
        protected void Page_Load(object sender, EventArgs e)
        {
            provider = new PersonRepository();
        }

public IEnumerable<Person> GetAllPersons() => provider.GetAll();
    }
}