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
    
    public partial class SP_DGC_GetAllUtilityInvoiceLineItemDetails_Result
    {
        public int UtilityInvoiceLineID { get; set; }
        public Nullable<long> UtilityInvoiceId { get; set; }
        public Nullable<int> GlAccountItemID { get; set; }
        public string LineNumber { get; set; }
        public string LineDescrption { get; set; }
        public Nullable<decimal> LineTotalAmount { get; set; }
        public string GlCode { get; set; }
        public Nullable<int> NonStockItemId { get; set; }
        public string NonstockItemName { get; set; }
    }
}