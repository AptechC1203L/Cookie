using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bowman
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var auth = new Authentication();
            if (auth.isAuthenticatedCookies(this.Request.Cookies) || auth.isAuthenticatedSession(this.Session))
            {
                // Redirect to homepage
                Response.Redirect("/Homepage.aspx");
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            var auth = new Authentication();

            if (auth.canLogin(username, password))
            {
                if (this.rememberCheckBox.Checked)
                {
                    Response.Cookies["Login"]["Username"] = username;
                    Response.Cookies["Login"]["Password"] = password;
                }

                Session["Username"] = username;
                Session["Password"] = password;

                Response.Redirect("/Homepage.aspx");
            }
        }
    }
}