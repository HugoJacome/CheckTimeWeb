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

public partial class PARAMETRO
{
    public int Id { get; set; }
    public int Id_empresa { get; set; }
    public string Nombre { get; set; }
    public string Especificacione { get; set; }
    public string Valor { get; set; }
    public string Estado { get; set; }
    public string Categoria { get; set; }
    public System.DateTime Fc { get; set; }
    public string Uc { get; set; }
    public System.DateTime Fm { get; set; }
    public string Um { get; set; }

    public virtual EMPRESA EMPRESA { get; set; }
}
