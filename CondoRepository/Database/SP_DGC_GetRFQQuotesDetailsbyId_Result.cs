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
    
    public partial class SP_DGC_GetRFQQuotesDetailsbyId_Result
    {
        public long RFQuotesID { get; set; }
        public Nullable<int> RFQID { get; set; }
        public string QuotesReference { get; set; }
        public string QuotesSubject { get; set; }
        public Nullable<decimal> QuotesPrice { get; set; }
        public Nullable<System.DateTime> EstimatecompletionTime { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<System.DateTime> QuotesReceivedDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyFaxNumber { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyContactPersonName { get; set; }
        public string ContactPersonMobilenumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string UploadedReferenceFile { get; set; }
        public string Comments { get; set; }
        public string TypeOfAddress { get; set; }
        public Nullable<int> AddressId { get; set; }
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