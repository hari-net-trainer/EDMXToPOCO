//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentralRepository.CentralDatabase
{
    using System;
    
    public partial class SP_DGC_GetCondoSubscriptionInvoiceConfigDetails_Result
    {
        public int InvoiceConfigId { get; set; }
        public Nullable<long> SubscriptionId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<float> LateFee { get; set; }
        public Nullable<int> IntrestFreeDays { get; set; }
        public Nullable<decimal> RateOfIntrestPerMonth { get; set; }
        public Nullable<System.DateTime> EffectiveFrom { get; set; }
    }
}
