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
    
    public partial class SP_DGC_GetAllUnitPurchaseDetailsByUnitIds_Result
    {
        public long UnitPurchaseRequestId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public string UnitName { get; set; }
        public long OwnerUserId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerMobileNumber { get; set; }
        public string OwnerEmail { get; set; }
        public string IsSelfOccupied { get; set; }
        public string OwnerAddress { get; set; }
        public Nullable<System.DateTime> UnitPurchaseDate { get; set; }
        public string SPAFilePath { get; set; }
        public Nullable<System.DateTime> EffectiveFrom { get; set; }
        public Nullable<System.DateTime> EffectiveTo { get; set; }
        public string TypeOfAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string AddressState { get; set; }
        public string PostalCode { get; set; }
        public string SourceOfRequestDesc { get; set; }
        public string TypeOfAddressDesc { get; set; }
    }
}
