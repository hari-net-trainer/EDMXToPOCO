using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIwithHelp.Controllers
{
    [RoutePrefix("api/DGC_User")]
    public class RepoController : ApiController
    {
        [Route("AllUsers")]
        [HttpGet]
        public List<SP_DGC_GetUserSubscriptionDetails_Result> GetallUserDetails(long userid)
        {
            return ModelMap.GetList(userid);
        }

        [Route("SaveUsers")]
        [HttpPost]
        public int SaveUserDetails(long centralUserId, string newPassword, string newMobileIMEA, string updatedBy)
        {
            return ModelMap.SaveUser(centralUserId, newPassword, newMobileIMEA, updatedBy);
        }

        [Route("GetUserSubScription")]
        [HttpPost]
        public Test GetUserSubScriptionDetails(string userMobileNumber, string userPassword, string googleFireBaseToken, string userAccessDevice, string isWebCalling)
        {
            return ModelMap.GetUserSubScriptionDetails(userMobileNumber, userPassword, googleFireBaseToken, userAccessDevice, isWebCalling);
        }

    }
}
