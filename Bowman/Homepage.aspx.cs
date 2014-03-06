using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bowman
{
    public partial class Homepage : System.Web.UI.Page
    {
        private bool useCookie = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            var auth = new Authentication();

            if (auth.isAuthenticatedCookies(this.Request.Cookies))
            {
                Session["Username"] = Request.Cookies["Login"]["Username"];
                Session["Password"] = Request.Cookies["Login"]["Password"];
                this.useCookie = true;
            }
            else
            {
                this.useCookie = false;
            }

            // Always use session as the main state management method
            if (auth.isAuthenticatedSession(this.Session))
            {
                this.toLoggedInState();
            }
            else
            {
                this.toLoggedOutState();
            }
        }

        private void toLoggedInState()
        {
            this.loginButton.Enabled = false;
            this.logoutButton.Enabled = true;
            this.welcomeText.Text = String.Format("Hello {0}. You authenticated using {1}.",
                Session["Username"],
                this.useCookie ? "cookie" : "ASP.NET session");
        }

        private void toLoggedOutState()
        {
            this.loginButton.Enabled = true;
            this.logoutButton.Enabled = false;
            this.welcomeText.Text = "Hello, Guest";
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Response.Cookies["Login"].Expires = DateTime.Now.AddDays(-1);
            Session.Abandon();
            Response.Redirect("/Homepage.aspx");
        }
    }
}