//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class question
    {
        public int q_id { get; set; }
        public string q_title { get; set; }
        public string q_opa { get; set; }
        public string q_opb { get; set; }
        public string q_opc { get; set; }
        public string q_opd { get; set; }
        public string q_opcorrect { get; set; }
        public string q_addeddate { get; set; }
        public Nullable<int> q_fk_ex { get; set; }
        public string ad_add { get; set; }
    
        public virtual admin_athu admin_athu { get; set; }
        public virtual exam exam { get; set; }
    }
}
