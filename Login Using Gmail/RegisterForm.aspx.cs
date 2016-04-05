using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Using_Gmail
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        VALayer ValLayer = new VALayer();
        DALayer DalLayer = new DALayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ValLayer.Name = Request.Form["Name"];
            ValLayer.Dob = DateTime.Parse(Request.Form["dob"]);
            ValLayer.Password = Request.Form["pass"];
            ValLayer.Email = Request.Form["mail"];
            DalLayer.Register(ValLayer);
            Response.Redirect("Login.aspx");
        }
    }
}