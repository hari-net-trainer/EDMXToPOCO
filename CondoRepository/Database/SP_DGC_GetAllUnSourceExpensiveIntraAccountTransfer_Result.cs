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
    
    public partial class SP_DGC_GetAllUnSourceExpensiveIntraAccountTransfer_Result
    {
        public long USRequestId { get; set; }
        public Nullable<int> TypeOfExpense { get; set; }
        public string ModeOfPayment { get; set; }
        public Nullable<int> FromCondoBankAccountID { get; set; }
        public Nullable<int> ToCondoBankAccountId { get; set; }
        public Nullable<decimal> TrasactionAmount { get; set; }
        public Nullable<System.DateTime> ActualTransactionDate { get; set; }
        public Nullable<System.DateTime> ChequePostDate { get; set; }
        public string TransactionReason { get; set; }
        public string ChequeOrReferenceNumber { get; set; }
        public string BankName { get; set; }
        public string FromBankName { get; set; }
        public string ToBankName { get; set; }
    }
}
