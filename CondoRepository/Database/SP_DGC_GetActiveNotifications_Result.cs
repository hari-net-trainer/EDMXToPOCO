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
    
    public partial class SP_DGC_GetActiveNotifications_Result
    {
        public int AnnouncementId { get; set; }
        public string AnnouncementSubject { get; set; }
        public string AnnouncementDescription { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public string ReferenceFilePath { get; set; }
        public string IsActive { get; set; }
    }
}
