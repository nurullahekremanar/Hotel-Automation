//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hotelEntities1 : DbContext
    {
        public hotelEntities1()
            : base("name=hotelEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<giris> giris { get; set; }
        public virtual DbSet<kategori> kategori { get; set; }
        public virtual DbSet<kiralama> kiralama { get; set; }
        public virtual DbSet<musteri> musteri { get; set; }
        public virtual DbSet<oda> oda { get; set; }
    }
}
