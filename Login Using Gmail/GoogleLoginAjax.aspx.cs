using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Using_Gmail
{
    public partial class GoogleLoginAjax : System.Web.UI.Page
    {
        VALayer ValLayer = new VALayer();
        DALayer DalLayer = new DALayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Please Wait";
            ValLayer.Email= Request.QueryString["email"];
            DalLayer.Logins(ValLayer);
        }
    }
}