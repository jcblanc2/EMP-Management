using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRECH.Repository;
using CRECH.Models;
using CRECH.UI;


/// <summary>
/// Christ- Yan Love LAROSE
/// </summary>
namespace CRECH
{
    public partial class FormulaireEmployesPage : System.Web.UI.Page
    {
        CRECHDbContext dbContext = new CRECHDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// Mehode to clear text box
        /// </summary>
        public void EmptyBoxes()
        {
            txtAdresse.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom1.Text = string.Empty;
            txtPrenom2.Text = string.Empty;
            txtDateEmbauche.Text = string.Empty;
            txtDateNaissance.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmail.Text = string.Empty;

            txtNomContact.Text = string.Empty;
            txtPrenomContact.Text = string.Empty;
            txtTelContact.Text = string.Empty;

            txtNom.Focus();
        }

        /// <summary>
        /// Methode to check if a string contains only letters
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool VerifyLetter(string word)
        {
            string trim = string.Concat(word.Where(c => !Char.IsWhiteSpace(c)));//delete all spaces

            foreach (char letter in trim)
            {
                if (!Char.IsLetter(letter))
                    if (letter != '-')
                        return false;
            }
            return true;
        }


        /// <summary>
        /// Methode to verify if the text boxes are empty.
        /// </summary>
        /// <returns></returns>
        public bool IfBoxEmpty()
        {
            TextBox[] texboxes = { txtNom, txtAdresse, txtDateNaissance, txtTelephone, txtDateEmbauche, txtEmail, txtNomContact, txtPrenomContact, txtTelContact };
            foreach (TextBox textBox in texboxes)
            {
                if (textBox.Text.Length == 0)
                    return true;
            }
            if (txtPrenom1.Text.Length == 0 || txtPrenom2.Text.Length == 0)
                return false;
            return false;
        }

        
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            EmptyBoxes();//clear all boxes
        }

        protected void btnAddEmp_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();
            string dateEmbauche = txtDateEmbauche.Text.Trim();
            string dateNaissance = txtDateNaissance.Text.Trim();
            string prenom = txtPrenom1.Text.Trim() + " " + txtPrenom2.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telephone = txtTelephone.Text.Trim();
            string sexe = DropSex.Text.Trim();
            string empId = "1001";

            string nomContact = txtNomContact.Text.Trim();
            string prenomContact = txtPrenomContact.Text.Trim();
            string telContact = txtTelContact.Text.Trim();
            string lien = DropLien.Text.Trim();

            var emp = dbContext.Employes.Where(em => em.Nom.Equals(nom) && em.Email.Equals(email)).FirstOrDefault();

            if (emp == null)
            {
                Employes employe = new Employes();

                employe.EmployeID = new Guid();
                employe.IdEmployePub = Convert.ToInt32(empId);
                employe.Nom = nom;
                employe.Prenom = prenom;
                employe.Sexe = sexe;
                employe.Email = email;
                employe.AdresseRue = adresse;
                employe.DateNaissance = dateNaissance;
                employe.DateEmbauche = dateEmbauche;
                employe.Telephone = telephone;
                employe.NomAContacter = nomContact;
                employe.PrenomAContacter = prenomContact;
                employe.LienParente = lien;
                employe.TelPersonne = telContact;

                dbContext.Employes.Add(employe);
                dbContext.SaveChanges();
            }
            else
            {
                Response.Write("<script>alert('Account Not Found')</script>");
            }
        }
    }
}