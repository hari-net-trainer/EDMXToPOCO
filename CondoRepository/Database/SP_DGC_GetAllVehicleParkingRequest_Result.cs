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
    
    public partial class SP_DGC_GetAllVehicleParkingRequest_Result
    {
        public long VehicleParkingRequestID { get; set; }
        public Nullable<int> VehicleSlotId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<long> OwnerOrTenantUserID { get; set; }
        public Nullable<System.DateTime> BookingFromDate { get; set; }
        public string BookingComment { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string SlotName { get; set; }
        public Nullable<System.DateTime> FinalBillingDate { get; set; }
        public Nullable<System.DateTime> LastRentBillToDate { get; set; }
        public string OwnerOrTenantName { get; set; }
        public string VehicleParkingStatus { get; set; }
        public string UnitName { get; set; }
    }
}
