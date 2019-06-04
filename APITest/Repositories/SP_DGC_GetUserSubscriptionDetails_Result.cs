using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public partial class SP_DGC_GetUserSubscriptionDetails_Result
    {
        public long CentralUserId { get; set; }
        public string UserMobileNumber { get; set; }
        public long SubscriptionId { get; set; }
        public string SubscriptionCode { get; set; }
        public string IsIndividual { get; set; }
        public string COMPANYNAME { get; set; }
        public string CompanyPICName { get; set; }
        public Nullable<System.DateTime> UserSubscriptionPeriodFrom { get; set; }
        public Nullable<System.DateTime> UserSubscriptionPeriodTo { get; set; }
        public Nullable<System.DateTime> CondoSubScriptionPeriodFrom { get; set; }
        public Nullable<System.DateTime> CondoSubScriptionPeriodTo { get; set; }
    }
}
