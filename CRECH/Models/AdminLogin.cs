﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRECH.Models
{
    public class AdminLogin
    {
        [Key]
        public Guid AdminID { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Actif { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime DateUpdated { get; set; } = DateTime.Now.ToUniversalTime();
    }
}