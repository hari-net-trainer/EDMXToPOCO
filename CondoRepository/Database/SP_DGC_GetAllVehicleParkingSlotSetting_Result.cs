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
    
    public partial class SP_DGC_GetAllVehicleParkingSlotSetting_Result
    {
        public int VehicleSlotId { get; set; }
        public string SlotName { get; set; }
        public Nullable<int> AllowdVehicleId { get; set; }
        public string IsVisitorParking { get; set; }
        public string IsActive { get; set; }
        public Nullable<System.DateTime> EffectiveTo { get; set; }
    }
}
