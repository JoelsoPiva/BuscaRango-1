
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BuscaRangoCode
{

using System;
    using System.Collections.Generic;
    
public partial class BR_Lista_Prato
{

    public BR_Lista_Prato()
    {

        this.BR_Prato = new HashSet<BR_Prato>();

    }


    public int Id { get; set; }

    public int Id_Usuario { get; set; }

    public string Nome_Lista { get; set; }



    public virtual BR_Usuario BR_Usuario { get; set; }

    public virtual ICollection<BR_Prato> BR_Prato { get; set; }

}

}
