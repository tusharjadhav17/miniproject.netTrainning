//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public long Id { get; set; }
        public System.DateTime AddedDate { get; set; }
        public long AuthorId { get; set; }
        public int IPAddress { get; set; }
        public Nullable<long> ISBN { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
    
        public virtual Auther Auther { get; set; }
    }
}
