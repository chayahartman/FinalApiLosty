//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    
    public partial class SPsearchCorrespondingLosses_Result
    {
        public int lostId { get; set; }
        public int userId { get; set; }
        public string lostName { get; set; }
        public Nullable<int> itemId { get; set; }
        public Nullable<System.DateTime> lostDate { get; set; }
        public string lostLocation { get; set; }
        public Nullable<int> lostStatus { get; set; }
        public string lostDescription { get; set; }
        public string lostModel { get; set; }
        public Nullable<System.DateTime> returnDate { get; set; }
    }
}
