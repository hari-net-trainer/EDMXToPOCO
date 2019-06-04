using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ModelMap
    {
        public static List<SP_DGC_GetUserSubscriptionDetails_Result> GetList(long id)
        {
            var obj = new List<SP_DGC_GetUserSubscriptionDetails_Result>();
            using (var db = new CentralDigiCondo())
            {
                var temp = db.SP_DGC_GetUserSubscriptionDetails(id);
                obj = temp.ToList();
            }
            return obj;
        }

        public static int SaveUser(long centralUserId, string newPassword, string newMobileIMEA, string updatedBy)
        {
            int obj = 0;
            ObjectParameter objErrorCode = new ObjectParameter("ErrorCode", typeof(Int32));
            using (var db = new CentralDigiCondo())
            {
                var temp = db.SP_DGC_SavePasswordDetails(centralUserId, newPassword, newMobileIMEA, updatedBy, objErrorCode);
                obj = temp;
            }
            return obj;
        }

        public static Test GetUserSubScriptionDetails(string userMobileNumber, string userPassword, string googleFireBaseToken, string userAccessDevice, string isWebCalling)
        {
            var tes = new Test();
            ObjectParameter objUserId = new ObjectParameter("CentralUserId", typeof(long));
            ObjectParameter objSubscriptionId = new ObjectParameter("SubscriptionId", typeof(long));
            ObjectParameter objSubscriptionCode = new ObjectParameter("SubscriptionCode", typeof(string));
            ObjectParameter objUserAuthToken = new ObjectParameter("UserAuthToken", typeof(string));
            using (var db = new CentralDigiCondo())
            {
                db.SP_DGC_ValidateUser_GetUserSubScriptionDetails(userMobileNumber, userPassword, googleFireBaseToken, userAccessDevice, isWebCalling, objUserId, objSubscriptionId, objSubscriptionCode, objUserAuthToken);
                tes.CentralUserId = (long)objUserId.Value;
                tes.SubscriptionId = (long)objSubscriptionId.Value;
                tes.SubscriptionCode = objSubscriptionCode.Value.ToString();
                tes.UserAuthToken = objUserAuthToken.Value.ToString();
            }
            return tes;
        }
    }

    public class Test
    {
        public long CentralUserId { get; set; }
        public long SubscriptionId { get; set; }
        public string SubscriptionCode { get; set; }
        public string UserAuthToken { get; set; }
    }
}
