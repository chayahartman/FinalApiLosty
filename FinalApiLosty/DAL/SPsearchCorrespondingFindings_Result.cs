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
    
    public partial class SPsearchCorrespondingFindings_Result
    {
        public int findingId { get; set; }
        public int userId { get; set; }
        public string findingName { get; set; }
        public Nullable<int> itemId { get; set; }
        public Nullable<System.DateTime> findDate { get; set; }
        public string findLocation { get; set; }
        public Nullable<int> findingStatus { get; set; }
        public string findingDescription { get; set; }
        public string findingModel { get; set; }
    }
}
