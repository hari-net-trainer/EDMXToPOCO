//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentralRepository
{
    using System;
    
    public partial class SP_DGC_GetEmailTemplate_Result
    {
        public int EmailTemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateStyle { get; set; }
        public string ReplaceWords { get; set; }
        public Nullable<bool> isHtmlTemplate { get; set; }
        public Nullable<bool> IsProdEnv { get; set; }
        public string DevloperToList { get; set; }
    }
}
