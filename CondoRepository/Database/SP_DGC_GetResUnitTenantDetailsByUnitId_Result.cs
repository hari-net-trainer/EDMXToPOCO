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
    
    public partial class SP_DGC_GetResUnitTenantDetailsByUnitId_Result
    {
        public long UserId { get; set; }
        public long UnitTenantRequestId { get; set; }
        public string Username { get; set; }
        public string USERMOBILENUMBER { get; set; }
        public string USEREMAIL { get; set; }
        public string UserProfilePath { get; set; }
        public Nullable<System.DateTime> TenancyAgreementDate { get; set; }
        public Nullable<System.DateTime> OccupiedFrom { get; set; }
        public Nullable<System.DateTime> OccupiedTo { get; set; }
        public string TenantCompanyName { get; set; }
        public string RENTALAgreementFilePath { get; set; }
    }
}
