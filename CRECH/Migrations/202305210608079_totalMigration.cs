namespace CRECH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class totalMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminLogins",
                c => new
                    {
                        AdminID = c.Guid(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(),
                        FullName = c.String(),
                        Actif = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        EmployeID = c.Guid(nullable: false),
                        IdEmployePub = c.Int(nullable: false),
                        Nom = c.String(),
                        Prenom = c.String(),
                        AdresseRue = c.String(),
                        Sexe = c.String(),
                        Telephone = c.String(),
                        DateNaissance = c.String(),
                        DateEmbauche = c.String(),
                        Actif = c.Boolean(nullable: false),
                        NomAContacter = c.String(),
                        PrenomAContacter = c.String(),
                        Email = c.String(),
                        LienParente = c.String(),
                        TelPersonne = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Guid(nullable: false),
                        FullName = c.String(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Actif = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MemberID);
            
            CreateTable(
                "dbo.ParcoursProfs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NomEmploye = c.String(),
                        IdEmployePub = c.Int(nullable: false),
                        Discipline = c.String(),
                        Date = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Guid(nullable: false),
                        NomEmploye = c.String(),
                        IdEmployePub = c.Int(nullable: false),
                        Departement = c.String(),
                        Poste = c.String(),
                        DateDebut = c.String(),
                        DateFin = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PromotionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Promotions");
            DropTable("dbo.ParcoursProfs");
            DropTable("dbo.Members");
            DropTable("dbo.Employes");
            DropTable("dbo.AdminLogins");
        }
    }
}
