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
    using System.Collections.Generic;
    
    public partial class oda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oda()
        {
            this.kiralama = new HashSet<kiralama>();
        }
    
        public int odaID { get; set; }
        public string odaKat { get; set; }
        public Nullable<int> odaKategori { get; set; }
        public string odaFiyat { get; set; }
        public Nullable<bool> odaDurum { get; set; }
    
        public virtual kategori kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kiralama> kiralama { get; set; }
    }
}