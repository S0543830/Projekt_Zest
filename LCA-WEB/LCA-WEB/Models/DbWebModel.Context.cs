﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LCA_WEB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbWebModelEntities : DbContext
    {
        public DbWebModelEntities()
            : base("name=DbWebModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<MengeEinheit> MengeEinheits { get; set; }
        public virtual DbSet<Produkt> Produkts { get; set; }
        public virtual DbSet<ProduktTyp> ProduktTyps { get; set; }
        public virtual DbSet<Rohstoff> Rohstoffs { get; set; }
        public virtual DbSet<Rohstoffe> Rohstoffes { get; set; }
        public virtual DbSet<Umweltindikator> Umweltindikators { get; set; }
        public virtual DbSet<Umweltindikatorwert> Umweltindikatorwerts { get; set; }
        public virtual DbSet<EndOfLifeData> EndOfLifeDatas { get; set; }
        public virtual DbSet<ProduktRohstoffUmweltindikator> ProduktRohstoffUmweltindikators { get; set; }
    }
}
