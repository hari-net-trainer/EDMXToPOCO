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
    
    public partial class SP_DGC_GetAllCreditNotes_Result
    {
        public long CreditNoteID { get; set; }
        public Nullable<int> IssueForID { get; set; }
        public Nullable<int> IssueToID { get; set; }
        public string CreditNumber { get; set; }
        public string CreditSubject { get; set; }
        public Nullable<decimal> CreditAmount { get; set; }
        public string IssueToAddress { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string StatusDes { get; set; }
        public string IssueFor { get; set; }
        public string IssueTo { get; set; }
        public string AcknowledgementFilePath { get; set; }
        public Nullable<long> InvoiceId { get; set; }
    }
}
