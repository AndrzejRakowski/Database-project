//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBDKarty
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gracz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gracz()
        {
            this.Statystyka = new HashSet<Statystyka>();
        }
    
        public int ID_Gracza { get; set; }
        public Nullable<System.DateTime> Data_Dolaczenia { get; set; }
        public Nullable<System.DateTime> Data_Urodzin { get; set; }
        public string E_mail { get; set; }
        public Nullable<int> ID_Talii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Statystyka> Statystyka { get; set; }
        public virtual Talia Talia { get; set; }
    }
}
