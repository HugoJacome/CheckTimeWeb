//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class PERSONA
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PERSONA()
    {
        this.EMPLEADO = new HashSet<EMPLEADO>();
        this.USUARIO = new HashSet<USUARIO>();
    }

    public int Id { get; set; }
    public string Nombre_1 { get; set; }
    public string Nombre_2 { get; set; }
    public string Apellido_1 { get; set; }
    public string Apellido_2 { get; set; }
    public string Tipo_documento { get; set; }
    public string Numero_documento { get; set; }
    public System.DateTime Fecha_nacimiento { get; set; }
    public string Email { get; set; }
    public int Id_ciudad { get; set; }
    public string Direccion { get; set; }
    public string Estado { get; set; }
    public System.DateTime Fc { get; set; }
    public string Uc { get; set; }
    public System.DateTime Fm { get; set; }
    public string Um { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<USUARIO> USUARIO { get; set; }
}
