//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pachienti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pachienti()
        {
            this.PriemPacientov = new HashSet<PriemPacientov>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public string Familia { get; set; }
        public string Otchestvo { get; set; }
        public System.DateTime DateOfBirthday { get; set; }
        public string Adress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriemPacientov> PriemPacientov { get; set; }
    }
}
