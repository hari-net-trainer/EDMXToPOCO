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
    
    public partial class SP_DGC_GetAllComiteeMembers_Result
    {
        public int CommiteeMemberId { get; set; }
        public Nullable<long> MemberUserId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public string UnitName { get; set; }
        public string Designation { get; set; }
        public Nullable<int> ElectionConductedYear { get; set; }
        public Nullable<System.DateTime> PeriodFrom { get; set; }
        public Nullable<System.DateTime> PeriodTo { get; set; }
        public string IsActive { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberMobileNumber { get; set; }
    }
}
