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
    
    public partial class SP_DGC_GetVisitorInButNotOutDetails_Result
    {
        public Nullable<int> UnitId { get; set; }
        public string UnitName { get; set; }
        public string UserName { get; set; }
        public string UserMobileNumber { get; set; }
        public string VisitorName { get; set; }
        public string VisitorMobileNumber { get; set; }
        public Nullable<System.DateTime> VisitingDateTime { get; set; }
        public string VisitorInTime { get; set; }
        public string VisitorOutTime { get; set; }
        public Nullable<System.DateTime> ExpectedLeavingDate { get; set; }
        public string ExpectedLeavingTime { get; set; }
        public string ExceedStayPeriodInDaysAndHours { get; set; }
    }
}
