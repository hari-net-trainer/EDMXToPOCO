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
    
    public partial class SP_DGC_GetClampRequestHistoryById_Result
    {
        public long CLAMPRequestId { get; set; }
        public string VehicleNumber { get; set; }
        public string REFERENCEFILEPATH { get; set; }
        public string CLAMPEDBY { get; set; }
        public Nullable<System.DateTime> CLAMPEDON { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<long> CRActionId { get; set; }
        public Nullable<int> REQUESTSTATUSID { get; set; }
        public string RequestStatus { get; set; }
        public string REQUESTCOMMENTS { get; set; }
        public Nullable<long> ACTIONTAKENBYUSERID { get; set; }
        public string ACTIONTAKENBY { get; set; }
        public Nullable<System.DateTime> ACTIONTAKENON { get; set; }
        public Nullable<long> PaymentRequestId { get; set; }
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
