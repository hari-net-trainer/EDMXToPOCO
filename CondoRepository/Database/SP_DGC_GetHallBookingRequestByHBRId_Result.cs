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
    
    public partial class SP_DGC_GetHallBookingRequestByHBRId_Result
    {
        public long HallBookingRequestId { get; set; }
        public string RequestFor { get; set; }
        public Nullable<int> UnitId { get; set; }
        public string UnitName { get; set; }
        public Nullable<long> livingMemberUserId { get; set; }
        public string LivingMemberName { get; set; }
        public string LivingMemberEmail { get; set; }
        public string LivingMemberMobileNo { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public Nullable<decimal> DepositAmount { get; set; }
        public Nullable<decimal> RentAmount { get; set; }
        public string PuproseOfBooking { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string RequestStatusDesc { get; set; }
        public Nullable<long> DepositPriceId { get; set; }
        public Nullable<long> RentPriceId { get; set; }
        public Nullable<long> RequestByUserId { get; set; }
        public string RequestedBy { get; set; }
        public Nullable<System.DateTime> RequestOn { get; set; }
        public string SlotName { get; set; }
        public string SLOTSTARTTIME { get; set; }
        public string SlotEndTime { get; set; }
    }
}
