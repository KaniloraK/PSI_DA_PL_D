//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestGest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carro()
        {
            this.Servicos = new HashSet<Servico>();
        }
    
        public int IdCarro { get; set; }
        public int ClienteIdCliente { get; set; }
        public string Matricula { get; set; }
    
        public virtual Cliente1 Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servico> Servicos { get; set; }
    }
}
