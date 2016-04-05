using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Using_Gmail
{
    public partial class Login : System.Web.UI.Page
    {
        DALayer dalayer = new DALayer();
        VALayer valayer = new VALayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            valayer.Name = TextBox1.Text;
            valayer.Password=TextBox2.Text;
            dalayer.Logins(valayer);
        }
    }
}