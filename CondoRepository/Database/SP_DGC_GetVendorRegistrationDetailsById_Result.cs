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
    
    public partial class SP_DGC_GetVendorRegistrationDetailsById_Result
    {
        public long VendorRegId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyFaxNumber { get; set; }
        public string CompanyEMail { get; set; }
        public Nullable<long> PICUserId { get; set; }
        public string PICName { get; set; }
        public string PICMobileNumber { get; set; }
        public string PICEmail { get; set; }
        public Nullable<System.DateTime> VendorContractFrom { get; set; }
        public Nullable<System.DateTime> VendorContractTo { get; set; }
        public Nullable<int> SuppliedNoOfPeople { get; set; }
        public string VendorAgreementFilePath { get; set; }
        public string IsActive { get; set; }
        public string CompanyGstNo { get; set; }
        public Nullable<int> VendorServiceTypeId { get; set; }
        public Nullable<int> UtilityTypeId { get; set; }
        public string OtherUtilityName { get; set; }
        public Nullable<int> CompanyAccountNo { get; set; }
        public Nullable<long> PICCentralUserId { get; set; }
        public string TypeOfAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string AddressState { get; set; }
        public string PostalCode { get; set; }
        public string SourceOfRequestKey { get; set; }
        public string SourceOfRequestDesc { get; set; }
        public string TypeOfAddressDesc { get; set; }
    }
}
