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
    
    public partial class SP_DGC_GetUNitBillSummaryByInvoiceID_Result
    {
        public string BillCode { get; set; }
        public string BillTypeName { get; set; }
        public Nullable<decimal> billamount { get; set; }
        public Nullable<System.DateTime> BillPeriodFrom { get; set; }
        public Nullable<System.DateTime> BillPeriodTo { get; set; }
    }
}