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
    
    public partial class SP_DGC_PG_GetPG_RequestResponseByPGResponseId_Result
    {
        public long PGRR_Id { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantKey { get; set; }
        public Nullable<int> PaymentId { get; set; }
        public Nullable<long> PaymentRequestId { get; set; }
        public string RefNo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Currency { get; set; }
        public string ProdDesc { get; set; }
        public Nullable<long> PaidByUserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserContact { get; set; }
        public Nullable<decimal> PercentageofChargesOnDirectPay { get; set; }
        public string Country { get; set; }
        public string Lang { get; set; }
        public string BackendPostUrl { get; set; }
    }
}
