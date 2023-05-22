using CRECH.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRECH.Models
{
    public class ParcoursProf
    {
        [Key]
        public int id { get; set; }
        public string NomEmploye { get; set; }
        public int IdEmployePub { get; set; }
        public string Discipline { get; set; }
        public string Date { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime DateUpdated { get; set; } = DateTime.Now.ToUniversalTime();
    }
}