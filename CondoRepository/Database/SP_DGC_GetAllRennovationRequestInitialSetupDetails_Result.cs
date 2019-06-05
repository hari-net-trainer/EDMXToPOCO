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
    
    public partial class SP_DGC_GetAllRennovationRequestInitialSetupDetails_Result
    {
        public int LineNumber { get; set; }
        public Nullable<int> RErrorNumber { get; set; }
        public string BlockName { get; set; }
        public string FloorName { get; set; }
        public string UnitName { get; set; }
        public Nullable<System.DateTime> PeriodFrom { get; set; }
        public Nullable<System.DateTime> PeriodTo { get; set; }
        public Nullable<decimal> DepositAmount { get; set; }
        public string CantractorName { get; set; }
        public string ContractorVehicalNumber { get; set; }
        public string ContractorMobileNumber { get; set; }
        public string RaisedBy { get; set; }
        public Nullable<System.DateTime> RaisedOn { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string ModeOfPayment { get; set; }
        public string ChequeNumber { get; set; }
        public string ChequeIssuedBankName { get; set; }
        public string PaidBy { get; set; }
        public string RecievedBy { get; set; }
        public string StatusDes { get; set; }
        public Nullable<int> BlockId { get; set; }
        public Nullable<int> FloorId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<long> RaisedByUserId { get; set; }
        public Nullable<long> RennovationRequestId { get; set; }
        public Nullable<long> RRActionId { get; set; }
        public Nullable<long> PaymentRequestId { get; set; }
        public string IsError { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string VerifiedBy { get; set; }
        public Nullable<System.DateTime> VerifiedOn { get; set; }
        public string RequestSeverityKey { get; set; }
        public string IsPettyCash { get; set; }
        public string ProcessStage { get; set; }
        public string RenovationRequestType { get; set; }
        public Nullable<int> RenovationRequestTypeKey { get; set; }
    }
}