﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbisTakipEntities : DbContext
    {
        public dbisTakipEntities()
            : base("name=dbisTakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdminler> tblAdminler { get; set; }
        public virtual DbSet<tblDepartmanlar> tblDepartmanlar { get; set; }
        public virtual DbSet<tblFirmalar> tblFirmalar { get; set; }
        public virtual DbSet<tblGorevDetaylar> tblGorevDetaylar { get; set; }
        public virtual DbSet<tblGorevler> tblGorevler { get; set; }
        public virtual DbSet<tblPersoneller> tblPersoneller { get; set; }
        public virtual DbSet<tblCagrilar> tblCagrilar { get; set; }
        public virtual DbSet<tblCagriDetay> tblCagriDetay { get; set; }
    }
}
