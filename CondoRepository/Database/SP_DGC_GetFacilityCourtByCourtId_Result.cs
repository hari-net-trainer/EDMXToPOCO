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
    
    public partial class SP_DGC_GetFacilityCourtByCourtId_Result
    {
        public int CourtID { get; set; }
        public string CourtName { get; set; }
        public string CourtDescription { get; set; }
        public Nullable<int> MaxNumberPersonsAllowedPerRequest { get; set; }
        public Nullable<int> MinNumberPersonsAllowedPerRequest { get; set; }
        public Nullable<int> FacilityId { get; set; }
        public string IsActive { get; set; }
        public string IsAllowMultipleBookingsForTimeSlot { get; set; }
    }
}
