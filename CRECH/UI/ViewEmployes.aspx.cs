using CRECH.Models;
using CRECH.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace CRECH.UI
{
    public partial class ViewEmployes : System.Web.UI.Page
    {
        CRECHDbContext dbContext = new CRECHDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindGrid();
            }
        }

        /// <summary>
        /// Binding data to gridView
        /// </summary>
        private void BindGrid()
        {
            EmployesGridView.DataSource = dbContext.Employes.ToList();
            EmployesGridView.DataBind();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = EmployesGridView.Rows[e.RowIndex];
            string employeId = EmployesGridView.DataKeys[e.RowIndex].Values[0].ToString();
            string nom = (row.FindControl("txtName") as TextBox).Text;
            string prenom = (row.FindControl("txtPrenom") as TextBox).Text;
            string sexe = (row.FindControl("txtSexe") as TextBox).Text;
            string telephone = (row.FindControl("txtTelephone") as TextBox).Text;

            EmployesGridView.EditIndex = -1;

            if (!employeId.Equals(""))
            {
                var v = dbContext.Employes.Where(m => m.EmployeID.ToString().Equals(employeId)
                && m.Nom.Equals(nom)).FirstOrDefault();
                if (v != null)
                {
                    v.Nom = nom;
                    v.Prenom = prenom;
                    v.Sexe = sexe;
                    v.Telephone = telephone;

                    dbContext.SaveChanges();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }

            BindGrid();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            EmployesGridView.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = EmployesGridView.Rows[e.RowIndex];
            string employeId = EmployesGridView.DataKeys[e.RowIndex].Values[0].ToString();

            var v = dbContext.Employes.Where(m => m.EmployeID.ToString().Equals(employeId)).FirstOrDefault();

            if(v != null)
            {
                dbContext.Employes.Remove(v);
                dbContext.SaveChanges();
            }

            BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            EmployesGridView.EditIndex = -1;
            BindGrid();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtNomEmploye.Text.Trim();
            EmployesGridView.DataSource = dbContext.Employes.Where(em => em.Nom.ToLower().Equals(value.ToLower()) ||
            em.Prenom.ToLower().Equals(value.ToLower()) || em.Telephone.Equals(value) || em.IdEmployePub.ToString().Equals(value)).ToList();
            EmployesGridView.DataBind();
        }

        protected void txtNomEmploye_TextChanged(object sender, EventArgs e)
        {
            string value = txtNomEmploye.Text.Trim();
            EmployesGridView.DataSource = dbContext.Employes.Where(em => em.Nom.ToLower().Contains(value.ToLower()) ||
            em.Prenom.ToLower().Contains(value.ToLower()) || em.Telephone.Contains(value) || em.IdEmployePub.ToString().Contains(value)).ToList();
            EmployesGridView.DataBind();
        }
    }
}