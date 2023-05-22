using CRECH.Models;
using CRECH.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRECH.UI
{
    public partial class PromotionPage : System.Web.UI.Page
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
            txtDebutFonction.Text = string.Empty;
            txtFinFonction.Text = string.Empty;
            IdEmployeTextBox.Text = string.Empty;
            NomTextBox.Text = string.Empty;
            DropDepartement.SelectedIndex = 0;
            DropPoste.SelectedIndex = 0;
        }

        /// <summary>
        /// Methode to verify if the text boxes are empty.
        /// </summary>
        /// <returns></returns>
        public bool IfBoxEmpty()
        {
            TextBox[] texboxes = { txtDebutFonction, txtFinFonction };
            foreach (TextBox textBox in texboxes)
            {
                if (textBox.Text.Length == 0)
                    return true;
            }
            return false;
        }

        private void BindGrid()
        {
            PromotionGridView.DataSource = dbContext.Promotion.ToList();
            PromotionGridView.DataBind();
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
                var v = dbContext.Promotion.Where(m => m.IdEmployePub == id &&
                m.Poste.Equals(DropPoste.Text) &&
                m.DateDebut.Equals(txtDebutFonction.Text.Trim())).FirstOrDefault();
                if (v == null)
                {
                    Promotion promotion = new Promotion();
                    promotion.PromotionID = new Guid();
                    promotion.NomEmploye = NomTextBox.Text.Trim();
                    promotion.IdEmployePub = Convert.ToInt32(IdEmployeTextBox.Text.Trim());
                    promotion.Departement = DropDepartement.Text;
                    promotion.Poste = DropPoste.Text;
                    promotion.DateDebut = txtDebutFonction.Text.Trim();
                    promotion.DateFin = txtFinFonction.Text.Trim();

                    dbContext.Promotion.Add(promotion);
                    dbContext.SaveChanges();
                }
                else
                {
                    Response.Write("<script>alert('Account Not Found')</script>");
                }
            }

            

        }
    }
}