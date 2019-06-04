namespace Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_DGC_CentralUserMaster
    {
        [Key]
        public long CentralUserId { get; set; }

        [StringLength(20)]
        public string UserMobileNumber { get; set; }

        [StringLength(500)]
        public string UserPassword { get; set; }

        [StringLength(100)]
        public string UserMobileIMEA { get; set; }

        [StringLength(1)]
        public string IsActive { get; set; }

        public DateTime? EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        [StringLength(200)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(200)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(20)]
        public string OTPCODE { get; set; }

        public DateTime? OTPISSUEDTIME { get; set; }

        public DateTime? OTPEXPIREDTIME { get; set; }

        [StringLength(1000)]
        public string UserDeviceId { get; set; }

        [StringLength(1000)]
        public string UserFireBaseKey { get; set; }

        [StringLength(500)]
        public string UserAuthToken { get; set; }

        [StringLength(100)]
        public string UserAccessDevice { get; set; }

        [StringLength(10)]
        public string CountryCode { get; set; }
    }
}
