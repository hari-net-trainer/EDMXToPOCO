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
    
    public partial class SP_DGC_GetAllAssetsPurchaseDetails_Result
    {
        public long AssetPurchaseId { get; set; }
        public Nullable<long> VendorRegId { get; set; }
        public string CompanyName { get; set; }
        public string AssetPurchaseOrderNumber { get; set; }
        public Nullable<System.DateTime> AssetPurchaseDate { get; set; }
        public Nullable<decimal> AssetPurchaseAmount { get; set; }
        public Nullable<int> WorkOrderID { get; set; }
        public Nullable<int> Statusid { get; set; }
        public string BillFilePath { get; set; }
        public string StatusDesc { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<System.DateTime> LastPaidOn { get; set; }
        public string AssetPurchasedBy { get; set; }
        public string PurchaseNotes { get; set; }
        public Nullable<long> CreatedByUserId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
