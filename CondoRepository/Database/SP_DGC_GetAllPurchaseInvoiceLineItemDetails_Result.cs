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
    
    public partial class SP_DGC_GetAllPurchaseInvoiceLineItemDetails_Result
    {
        public int PurchaseInvoiceLineID { get; set; }
        public Nullable<long> PurchaseInvoiceId { get; set; }
        public Nullable<int> GlAccountItemID { get; set; }
        public string LineNumber { get; set; }
        public string LineItemDescription { get; set; }
        public Nullable<int> PurchaseQunitity { get; set; }
        public Nullable<decimal> PricePerUnit { get; set; }
        public Nullable<decimal> TaxPercentageperUnit { get; set; }
        public Nullable<decimal> TaxAmountPerUnit { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> TotalAmountPerUnit { get; set; }
        public Nullable<decimal> LineTotalAmount { get; set; }
        public Nullable<long> MaterialID { get; set; }
        public string ISLoanApplicable { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public Nullable<int> AccountItemNo { get; set; }
        public string MaterialName { get; set; }
        public Nullable<int> NonStockItemId { get; set; }
        public string NonstockItemName { get; set; }
    }
}