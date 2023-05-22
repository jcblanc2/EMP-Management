using CRECH.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
/// <summary>
/// Christ- Yan Love LAROSE
/// </summary>
namespace CRECH.Models
{
    public class Employes
    {
        [Key]
        public Guid EmployeID { get; set; }
        public int IdEmployePub { get; set; }
        public string Nom { get;set; }
        public string Prenom { get; set; }
        public string AdresseRue { get; set; }
        public string Sexe { get; set; }    
        public string Telephone { get; set; }
        public string DateNaissance { get; set; }
        public string DateEmbauche { get; set; }
        public bool Actif { get; set; } = true;
        public string NomAContacter { get; set; }
        public string PrenomAContacter { get; set; }
        public string Email { get; set; }
        public string LienParente { get; set; }
        public string TelPersonne { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime DateUpdated { get; set; } = DateTime.Now.ToUniversalTime();
    }
}