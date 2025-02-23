﻿
using DLWMS.WinForms.IB200054;
using System.Data.Entity;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Studenti");                      
        }       
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmeti> Predmeti { get; set; }
        public DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
        public DbSet<Slike> Slike { get; set; }
        public DbSet<StudentiSlike> StudentiSlike { get; set; }
       
    }
}