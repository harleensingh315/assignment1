//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Screen
    {
        public string Theater_id { get; set; }
        public string Screen_id { get; set; }
        public Nullable<decimal> No_of_Seats { get; set; }
        public string Current_Movie { get; set; }
        public string ThreeD { get; set; }
    
        public virtual Theater Theater { get; set; }
    }
}
