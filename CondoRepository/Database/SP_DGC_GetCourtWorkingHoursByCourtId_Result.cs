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
    
    public partial class SP_DGC_GetCourtWorkingHoursByCourtId_Result
    {
        public int CourtWorkingHoursID { get; set; }
        public Nullable<int> CourtID { get; set; }
        public Nullable<int> DaysId { get; set; }
        public string IsWorking { get; set; }
        public string Is24Hours { get; set; }
        public string MorningFromTime { get; set; }
        public string MorningToTime { get; set; }
        public string AfternoonFromTime { get; set; }
        public string AfternoonToTime { get; set; }
        public string EveningFromTime { get; set; }
        public string EveningToTime { get; set; }
        public string NightFromTime { get; set; }
        public string NightToTime { get; set; }
    }
}