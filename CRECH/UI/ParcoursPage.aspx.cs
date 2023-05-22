using CRECH.Models;
using CRECH.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRECH.UI
{
    public partial class ParcoursPage : System.Web.UI.Page
    {
        CRECHDbContext dbContext = new CRECHDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        /// <summary>
        /// Mehode to clear text box
        /// </summary>
        public void EmptyBoxes()
        {
            DateTextBox.Text = string.Empty;
            NomTextBox.Text = string.Empty;
            IdEmployeTextBox.Text = string.Empty;
        }

        private void BindGrid()
        {
            ParcoursGridView.DataSource = dbContext.ParcoursesProf.ToList();
            ParcoursGridView.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            EmptyBoxes();//clear all boxes
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdEmployeTextBox.Text.Trim());
            if (!id.Equals(""))
            {
                var v = dbContext.ParcoursesProf.Where(m => m.IdEmployePub == id &&
                m.Discipline.Equals(DropDetention.Text) &&
                m.Date.Equals(DateTextBox.Text.Trim())).FirstOrDefault();
                if (v == null)
                {
                    ParcoursProf parcours = new ParcoursProf();
                    parcours.NomEmploye = NomTextBox.Text.Trim();
                    parcours.IdEmployePub = Convert.ToInt32(IdEmployeTextBox.Text.Trim());
                    parcours.Discipline = DropDetention.Text.Trim();
                    parcours.Date = DateTextBox.Text.Trim();

                    dbContext.ParcoursesProf.Add(parcours);
                    dbContext.SaveChanges();

                    BindGrid();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }
        }
    }
}