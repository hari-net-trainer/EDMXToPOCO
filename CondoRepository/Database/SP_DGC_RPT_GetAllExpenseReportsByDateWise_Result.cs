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
    
    public partial class SP_DGC_RPT_GetAllExpenseReportsByDateWise_Result
    {
        public string UnitName { get; set; }
        public string PaymentCategory { get; set; }
        public string PaymentPaidByUserName { get; set; }
        public string PaymentRecievedByUserName { get; set; }
        public Nullable<System.DateTime> paymentdate { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string PaymentMode { get; set; }
    }
}
