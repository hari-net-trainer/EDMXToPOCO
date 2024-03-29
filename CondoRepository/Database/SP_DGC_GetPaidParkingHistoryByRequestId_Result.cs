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
    
    public partial class SP_DGC_GetPaidParkingHistoryByRequestId_Result
    {
        public long VehicleParkingRequestID { get; set; }
        public Nullable<int> VehicleSlotId { get; set; }
        public Nullable<int> AllowdVehicleId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public string UnitName { get; set; }
        public Nullable<long> OwnerOrTenantUserID { get; set; }
        public Nullable<System.DateTime> BookingFromDate { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string VehicleParkPriceIds { get; set; }
        public Nullable<System.DateTime> LastRentBillFromDate { get; set; }
        public Nullable<System.DateTime> LastRentBillToDate { get; set; }
        public Nullable<System.DateTime> FinalBillingDate { get; set; }
        public Nullable<System.DateTime> DeactivationDate { get; set; }
        public long VPRActionId { get; set; }
        public Nullable<int> RequestStatusId { get; set; }
        public string RequestComments { get; set; }
        public Nullable<long> PaymentRequestId { get; set; }
        public string AdditionalReferenceFilePath { get; set; }
        public Nullable<long> ActionTakenByUserId { get; set; }
        public string ActionTakenBy { get; set; }
        public Nullable<System.DateTime> ActionTakenOn { get; set; }
        public string ActionTakenByUserName { get; set; }
        public string LivingMemberUserName { get; set; }
        public string RequestStatus { get; set; }
        public Nullable<System.DateTime> PAYMENTDATE { get; set; }
        public Nullable<decimal> PAYMENTAMOUNT { get; set; }
        public string paymentmode { get; set; }
        public string CHEQUENUMBER { get; set; }
        public string CHEQUEISSUEBANKNAME { get; set; }
        public Nullable<long> paymentrecievedbyuserid { get; set; }
        public string PaymentReceivedByUser { get; set; }
        public Nullable<long> PAYMENTPAIDBYUSERID { get; set; }
        public string PaymentPAIDByUser { get; set; }
        public string PAYMENTRECIPTFILEPATH { get; set; }
    }
}
