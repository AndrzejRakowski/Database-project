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
    
    public partial class Karty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Karty()
        {
            this.Kreatury = new HashSet<Kreatury>();
            this.Mana = new HashSet<Mana>();
            this.Planeswalker = new HashSet<Planeswalker>();
            this.Karty_Talia = new HashSet<Karty_Talia>();
        }
    
        public int ID_Karty { get; set; }
        public string Nazwa_Karty { get; set; }
        public string Grafika { get; set; }
        public string Koszt { get; set; }
        public string Typ { get; set; }
        public string Edycja { get; set; }
        public string Opis { get; set; }
        public Nullable<int> Rok { get; set; }
        public string Autor_Grafiki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kreatury> Kreatury { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mana> Mana { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planeswalker> Planeswalker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karty_Talia> Karty_Talia { get; set; }
    }
}
