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
    
    public partial class SP_DGC_GetAllVendorComapnyMembersDetails_Result
    {
        public int VendorMemberId { get; set; }
        public Nullable<long> VendorRegId { get; set; }
        public Nullable<long> MemberUserid { get; set; }
        public Nullable<int> MemberDepartmentId { get; set; }
        public Nullable<long> MemberCentralisedUserId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmailID { get; set; }
        public string MemberUserMobileNumber { get; set; }
        public string IsActive { get; set; }
        public string DeactiveComment { get; set; }
        public Nullable<System.DateTime> EffectiveFrom { get; set; }
        public Nullable<System.DateTime> EffectiveTo { get; set; }
    }
}
