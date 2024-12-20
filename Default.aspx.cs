using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SimpleCRUD.Controllers;

namespace SimpleCRUD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddPerson_Click(object sender, EventArgs e)
        {
            Model person = new Model();
            person.Name = txtName.Text;
            person.Age = txtAge.Text;

            DefaultController defaultController = new DefaultController();
            defaultController.PersonTable(person);

                  
        }
    }
}