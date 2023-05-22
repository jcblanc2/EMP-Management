using CRECH.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRECH.UI
{
    public partial class UserLogin : System.Web.UI.Page
    {
        CRECHDbContext DbContext = new CRECHDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = MemberUsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            var v = DbContext.Members.Where(m => m.Username.Equals(username) && m.Password.Equals(password)).FirstOrDefault();
            if (v != null)
            {
                //Allow access
                Session["username"] = v.Username;
                Session["fullname"] = v.FullName;
                Session["role"] = "user";
                Response.Redirect("FormulaireEmployesPage.aspx");
            }
            else
            {
                //Deny Access
                Response.Write("<script>alert('Invalid Request')</script>");
            }
        }
    }
}