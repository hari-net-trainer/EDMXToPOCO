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
    
    public partial class SP_DGC_GetAllAssetsPurchaseActionDetails_Result
    {
        public int APurchaseActionId { get; set; }
        public Nullable<long> AssetPurchaseId { get; set; }
        public string ActionTakenBy { get; set; }
        public Nullable<System.DateTime> ActionTakenOn { get; set; }
        public Nullable<decimal> AssetPurchaseAmount { get; set; }
        public string IsTransposed { get; set; }
    }
}
