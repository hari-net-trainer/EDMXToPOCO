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
    
    public partial class SP_DGC_GetAllClampRequestDetails_Result
    {
        public long ClampRequestId { get; set; }
        public string VehicleNumber { get; set; }
        public string ClampRemarks { get; set; }
        public string ReferenceFilePath { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string StatusDesc { get; set; }
        public Nullable<long> ClampedByUserId { get; set; }
        public string ClampedBy { get; set; }
        public Nullable<System.DateTime> ClampedOn { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<long> AmountId { get; set; }
        public string UnitName { get; set; }
        public Nullable<long> LivingMemberUserid { get; set; }
        public string VisitorName { get; set; }
        public string LivingMemberName { get; set; }
        public string VehicleFrom { get; set; }
        public string UserMobileNumber { get; set; }
    }
}
