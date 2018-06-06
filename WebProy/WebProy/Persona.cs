//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.Domicilio = new HashSet<Domicilio>();
        }
    
        public int id { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [DisplayName("Número de documento")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo números, sin puntos ni espacios")]
        public Nullable<int> NumeroDocumento { get; set; }
        public Nullable<int> TipoDocumento_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Domicilio> Domicilio { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }

     
    }
}
