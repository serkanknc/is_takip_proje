//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblGorevler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGorevler()
        {
            this.tblGorevDetaylar = new HashSet<tblGorevDetaylar>();
        }
    
        public int ID { get; set; }
        public Nullable<int> GorevVeren { get; set; }
        public Nullable<int> GorevAlan { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGorevDetaylar> tblGorevDetaylar { get; set; }
        public virtual tblPersoneller tblPersoneller { get; set; }
        public virtual tblPersoneller tblPersoneller1 { get; set; }
    }
}
