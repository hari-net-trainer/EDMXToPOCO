//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CondoRepository.Database
{
    using System;
    
    public partial class SP_DGC_GetAllComplaintDetails_Result
    {
        public long ComplaintId { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string ComplSubject { get; set; }
        public string ComplDescription { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string StatusDesc { get; set; }
        public Nullable<long> RaisedByUserId { get; set; }
        public string RaisedBy { get; set; }
        public Nullable<System.DateTime> RaisedOn { get; set; }
        public string ReferenceDocPath { get; set; }
        public Nullable<long> AssignedToUserId { get; set; }
        public string AssignedTo { get; set; }
    }
}