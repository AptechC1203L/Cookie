using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bowman
{
    public class Authentication
    {
        private string defaultUsername = "root";
        private string defaultPassword = "admin";

        public bool isAuthenticatedCookies(HttpCookieCollection cookies)
        {
            return cookies["Login"] != null &&
                   cookies["Login"]["Username"] != null &&
                   cookies["Login"]["Password"] != null;
        }

        public bool canLogin(string username, string password)
        {
            return true;
            //return username.Equals(defaultUsername) && password.Equals(defaultPassword);
        }

        internal bool isAuthenticatedSession(System.Web.SessionState.HttpSessionState httpSessionState)
        {
            return httpSessionState["Username"] != null && httpSessionState["Password"] != null;
        }
    }
}