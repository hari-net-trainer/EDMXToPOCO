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
    
    public partial class SP_DGC_GetFacilityLinePackagePriceDetailsByLineId_Result
    {
        public int UnitRequestItemId { get; set; }
        public string UnitRequestItem { get; set; }
        public Nullable<int> PackageConfigKey { get; set; }
        public string PackageName { get; set; }
        public int URItemPackageMapID { get; set; }
        public Nullable<int> ItemFeeTypeId { get; set; }
        public string CurrentItemFeeXML { get; set; }
        public string NewItemFeeXML { get; set; }
        public Nullable<System.DateTime> EffectiveFrom { get; set; }
        public Nullable<int> URItemFeeConfigId { get; set; }
        public string IsDeposit { get; set; }
        public Nullable<System.DateTime> EffectiveTo { get; set; }
        public string IsActive { get; set; }
    }
}