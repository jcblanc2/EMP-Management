using CRECH.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRECH
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                LogoutNavLinkButton_Click(sender, e);
            }
            try
            {
                if (Session["role"].Equals(""))
                {
                    UserLoginNavLinkButton.Visible = true;
                    LogoutNavLinkButton.Visible = false;
                    HelloUserNavLinkButton.Visible = false;
                    AdminLoginNavLinkButton.Visible = true;

                    EmployeManagementBtn.Visible = false;
                    ParcoursManagementBtn.Visible = false;
                    PromotionManagementBtn.Visible = false;
                    MemberManagementBtn.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    UserLoginNavLinkButton.Visible = false;
                    LogoutNavLinkButton.Visible = true;
                    HelloUserNavLinkButton.Text = "Hello, " + Session["fullname"];
                    AdminLoginNavLinkButton.Visible = true;

                    EmployeManagementBtn.Visible = true;
                    ParcoursManagementBtn.Visible = true;
                    PromotionManagementBtn.Visible = true;
                    MemberManagementBtn.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    UserLoginNavLinkButton.Visible = false;
                    LogoutNavLinkButton.Visible = true;
                    HelloUserNavLinkButton.Text = "Hello, Admin";
                    AdminLoginNavLinkButton.Visible = false;

                    EmployeManagementBtn.Visible = true;
                    ParcoursManagementBtn.Visible = true;
                    PromotionManagementBtn.Visible = true;
                    MemberManagementBtn.Visible = true;
                }
            }
            catch (Exception)
            {
            }
        }

        protected void AdminLoginButton_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["status"] = "";
            Session["role"] = "";
            Response.Redirect("AdminLogin.aspx");
        }

        protected void UserLoginNavLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void LogoutNavLinkButton_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["status"] = "";
            Session["role"] = "";
            Response.Redirect("UserLogin.aspx");
        }

        protected void PromotionManagementBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PromotionPage.aspx");
        }

        protected void MemberManagementBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("MembresPage.aspx");
        }

        protected void ParcoursManagementBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ParcoursPage.aspx");
        }

        protected void EmployeManagementBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormulaireEmployesPage.aspx");
        }

        protected void ViewEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewEmployes.aspx");
        }
    }
}
