using ChamikaToysHouse_FrontEnd.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChamikaToysHouse_FrontEnd
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ServiceClient obj = new ServiceClient();
            string un = username.Text.Trim();
            string pw = password.Text.Trim();
            string Error = "";
            string ErrorUser = "";
            string ErrorPassword = "";
            if (un == "" && pw == "")
            {
                Error = "Enter Your Username & Password !";
            }
            else if (un == "")
            {
                ErrorUser = "Enter Your Username !";
            }
            else if (pw == "")
            {
                ErrorPassword = "Enter Your Password !";
            }
            else if (obj.ChkLogin(un, pw))
            {
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Error = "Invalid Username or Password ! Please Enter Correct Username Password";
            }
            errorShow.Text = Error;
            errorUser.Text = ErrorUser;
            errorPassword.Text = ErrorPassword;
        }
    }
}