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
    
    public partial class SP_DGC_GetAllReconcilationDetailsByMonth_Result
    {
        public long BankReconciliationId { get; set; }
        public Nullable<int> PaymentReqId { get; set; }
        public string ModeOfPayment { get; set; }
        public string PaymentCRDB { get; set; }
        public Nullable<System.DateTime> ActualPaymentDate { get; set; }
        public string ChequeOrReferenceName { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string BankName { get; set; }
        public Nullable<int> ManagementBankAccountId { get; set; }
        public string IsReconciliation { get; set; }
        public Nullable<System.DateTime> ReconciliationDate { get; set; }
        public string IsCarryForward { get; set; }
        public string CarryForwardMonth { get; set; }
        public string CarryForwardToMonth_History { get; set; }
        public string ReconciliationComment { get; set; }
    }
}
