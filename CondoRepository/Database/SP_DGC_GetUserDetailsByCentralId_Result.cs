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
    
    public partial class SP_DGC_GetUserDetailsByCentralId_Result
    {
        public long UserId { get; set; }
        public string USERNAME { get; set; }
        public string IsMalaysian { get; set; }
        public string ICORPASSPORTNUMBER { get; set; }
        public string UserVisaExpirity { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string RoleName { get; set; }
        public string UserAddresss { get; set; }
        public string UserEmail { get; set; }
        public string UserMobileNumber { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string CountryName { get; set; }
        public string UserProfilePath { get; set; }
        public string IsActive { get; set; }
        public string IsLogInEnabled { get; set; }
        public Nullable<long> CentralisedUserId { get; set; }
        public string CountryMobileCode { get; set; }
        public string IsCommitteeMember { get; set; }
    }
}