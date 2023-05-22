using CRECH.Models;
using CRECH.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRECH.UI
{
    public partial class MembresPage : System.Web.UI.Page
    {
        CRECHDbContext dbContext = new CRECHDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            MemberGridView.DataSource = dbContext.Members.ToList();
            MemberGridView.DataBind();
        }

        protected void GoButton_Click(object sender, EventArgs e)
        {
            string username = MemberUsernameTextBox.Text.Trim();
            if (!username.Equals(""))
            {
                var v = dbContext.Members.Where(m => m.Username.Equals(username)).FirstOrDefault();
                if (v != null)
                {
                    Clear();
                    FullNameTextBox.Text = v.FullName;
                    MemberUsernameTextBox.Text = v.Username;
                    PwdTextBox.Text = v.Password;
                    StatusDropDownList.Text = v.Actif.ToString();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }
        }

        private void Clear()
        {
            FullNameTextBox.Text = "";
            MemberUsernameTextBox.Text = "";
            PwdTextBox.Text = "";
            StatusDropDownList.SelectedValue = "-- SELECT --";
        }
  
        protected void AddMember_Click(object sender, EventArgs e)
        {
            string username = MemberUsernameTextBox.Text.Trim();
            if (!username.Equals(""))
            {
                var v = dbContext.Members.Where(m => m.Username == username).FirstOrDefault();
                if (v == null)
                {
                    Member member = new Member();
                    member.MemberID = new Guid();
                    member.Username = MemberUsernameTextBox.Text;
                    member.Password = PwdTextBox.Text;
                    member.Actif = StatusDropDownList.SelectedValue.Equals("Actif") ? true : false;
                    member.FullName = FullNameTextBox.Text;

                    dbContext.Members.Add(member);
                    dbContext.SaveChanges();

                    BindGrid();
                    Clear();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }
        }

        protected void UpdateMember_Click(object sender, EventArgs e)
        {
            string username = MemberUsernameTextBox.Text.Trim();
            if (!username.Equals(""))
            {
                var v = dbContext.Members.Where(m => m.Username == username).FirstOrDefault();
                if (v != null)
                {
                    v.Username = MemberUsernameTextBox.Text;
                    v.Password = PwdTextBox.Text;
                    v.Actif = StatusDropDownList.SelectedValue.Equals("Actif") ? true : false;
                    v.FullName = FullNameTextBox.Text;

                    dbContext.SaveChanges();
                    BindGrid();
                    Clear();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }
        }

        protected void DeleteMember_Click(object sender, EventArgs e)
        {
            string username = MemberUsernameTextBox.Text.Trim();
            if (!username.Equals(""))
            {
                var v = dbContext.Members.Where(m => m.Username == username).FirstOrDefault();
                if (v != null)
                {
                    dbContext.Members.Remove(v);
                    dbContext.SaveChanges();

                    BindGrid();
                    Clear();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }
        }
    }
}