
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
    
public partial class BR_Caracteristica_Estabelecimento
{

    public BR_Caracteristica_Estabelecimento()
    {

        this.BR_Avaliacao_Estabelecimento = new HashSet<BR_Avaliacao_Estabelecimento>();

    }


    public int Id { get; set; }

    public string Caracteristica { get; set; }



    public virtual ICollection<BR_Avaliacao_Estabelecimento> BR_Avaliacao_Estabelecimento { get; set; }

}

}
