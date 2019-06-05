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
    
    public partial class SP_DGC_GetAllUnitShopRentBillDetails_Result
    {
        public string UnitName { get; set; }
        public string invoiceNumber { get; set; }
        public Nullable<System.DateTime> BillPeriodFrom { get; set; }
        public Nullable<System.DateTime> BillPeriodTo { get; set; }
        public Nullable<System.DateTime> BillGeneratedOn { get; set; }
        public Nullable<System.DateTime> BillDueOn { get; set; }
        public string InvoiceStatus { get; set; }
        public Nullable<int> statusid { get; set; }
        public string BillToShopPIC { get; set; }
        public Nullable<int> ShopRegistrationId { get; set; }
        public Nullable<int> ShopPICId { get; set; }
        public Nullable<float> UnitBuiltUpArea { get; set; }
        public Nullable<decimal> TotalBillAmount { get; set; }
        public long InvoiceId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> IntrestAmount { get; set; }
        public Nullable<decimal> BalanceAmount { get; set; }
        public Nullable<System.DateTime> LastPaymentDate { get; set; }
        public Nullable<int> PeriodOfIntrestInDays { get; set; }
        public string BillReferencePath { get; set; }
    }
}
