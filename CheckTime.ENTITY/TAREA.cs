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

public partial class TAREA
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TAREA()
    {
        this.PERFIL_TAREA = new HashSet<PERFIL_TAREA>();
    }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Especificacion { get; set; }
    public int Id_menu { get; set; }
    public string Url { get; set; }
    public string Estado { get; set; }
    public System.DateTime Fc { get; set; }
    public string Uc { get; set; }
    public System.DateTime Fm { get; set; }
    public string Um { get; set; }

    public virtual MENU MENU { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PERFIL_TAREA> PERFIL_TAREA { get; set; }
}
