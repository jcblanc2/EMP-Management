using CRECH.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRECH.Repository
{
    public class CRECHDbContext : DbContext
    {
        public DbSet<Employes> Employes { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<ParcoursProf> ParcoursesProf { get; set; }
        public DbSet<AdminLogin> Admins { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}