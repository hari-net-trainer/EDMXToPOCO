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
    
    public partial class SP_DGC_InitialSetUp_GetAllTenantSetupDetails_Result
    {
        public int TenantSetupID { get; set; }
        public string BlockName { get; set; }
        public string FloorName { get; set; }
        public string UnitName { get; set; }
        public string TenantName { get; set; }
        public string TenantEmail { get; set; }
        public string TenantMobilenumber { get; set; }
        public string ErrorMessage { get; set; }
        public string ProcessingStage { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> Errorcode { get; set; }
        public Nullable<int> UnitPurchaseRequestId { get; set; }
        public Nullable<int> TenantRequestId { get; set; }
        public Nullable<int> TenantUserid { get; set; }
        public Nullable<int> TenantCentralUserid { get; set; }
    }
}
