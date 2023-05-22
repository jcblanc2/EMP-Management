using CRECH.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRECH.Models
{
    public class Promotion
    {
        [Key]
        public Guid PromotionID { get; set; }
        public string NomEmploye { get; set; }
        public int IdEmployePub { get; set; }
        public string Departement { get; set; }
        public string Poste { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime DateUpdated { get; set; } = DateTime.Now.ToUniversalTime();
    }
}