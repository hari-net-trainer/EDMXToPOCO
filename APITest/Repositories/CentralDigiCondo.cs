namespace Repositories
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Data;

    public partial class CentralDigiCondo : DbContext
    {
        public CentralDigiCondo()
            : base("name=CentralDigiCondo")
        {
        }

        public virtual DbSet<Tbl_DGC_CentralUserMaster> Tbl_DGC_CentralUserMaster { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserMobileNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserMobileIMEA)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.IsActive)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.OTPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserDeviceId)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserFireBaseKey)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserAuthToken)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.UserAccessDevice)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_DGC_CentralUserMaster>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);
        }

        public virtual ObjectResult<SP_DGC_GetUserSubscriptionDetails_Result> SP_DGC_GetUserSubscriptionDetails(Nullable<Int64> centralUserId)
        {
            var centralUserIdParameter = centralUserId.HasValue ?
                new SqlParameter("CentralUserId", centralUserId) :
                new SqlParameter("CentralUserId", System.Data.SqlDbType.BigInt);

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreQuery<SP_DGC_GetUserSubscriptionDetails_Result>("SP_DGC_GetUserSubscriptionDetails @CentralUserId", centralUserIdParameter);
        }

        public virtual int SP_DGC_SavePasswordDetails(Nullable<Int64> centralUserId, string newPassword, string newMobileIMEA, string updatedBy, ObjectParameter errorcode)
        {
            var centralUserIdParameter = centralUserId.HasValue ?
                new SqlParameter("CentralUserId", centralUserId) :
                new SqlParameter("CentralUserId", System.Data.SqlDbType.BigInt);

            var newPasswordParameter = newPassword != null ?
                new SqlParameter("NewPassword", newPassword) :
                new SqlParameter("NewPassword", System.Data.SqlDbType.VarChar);

            var newMobileIMEAParameter = newMobileIMEA != null ?
                new SqlParameter("NewMobileIMEA", newMobileIMEA) :
                new SqlParameter("NewMobileIMEA", System.Data.SqlDbType.VarChar);

            var updatedByParameter = updatedBy != null ?
                new SqlParameter("UpdatedBy", updatedBy) :
                new SqlParameter("UpdatedBy", System.Data.SqlDbType.VarChar);

            var errorcode1 = new SqlParameter("Errorcode", System.Data.SqlDbType.Int);
            errorcode1.Direction = System.Data.ParameterDirection.Output;
            errorcode1.Value = errorcode != null ? errorcode.Value : null;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("SP_DGC_SavePasswordDetails @CentralUserId, @NewPassword, @NewMobileIMEA, @UpdatedBy, @Errorcode", centralUserIdParameter, newPasswordParameter, newMobileIMEAParameter, updatedByParameter, errorcode1);
        }

        public virtual int SP_DGC_ValidateCentralUserAuthToken(string userAuthToken, string appCode, string centralUserId, ObjectParameter errorCode)
        {

            var userAuthTokenParameter = userAuthToken != null ?
                new SqlParameter("UserAuthToken", userAuthToken) :
                new SqlParameter("UserAuthToken", SqlDbType.VarChar);

            var appCodeParameter = appCode != null ?
                new SqlParameter("AppCode", appCode) :
                new SqlParameter("AppCode", SqlDbType.VarChar);

            var centralUserIdParameter = centralUserId != null ?
                new SqlParameter("CentralUserId", centralUserId) :
                new SqlParameter("CentralUserId", SqlDbType.VarChar);

            var errorCodeParameter = new SqlParameter("ErrorCode", SqlDbType.Int);
            errorCodeParameter.Direction = System.Data.ParameterDirection.Output;
            errorCodeParameter.Value = errorCode != null ? errorCode.Value : null;


            var ret = ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("SP_DGC_ValidateCentralUserAuthToken @UserAuthToken, @AppCode, @CentralUserId, @ErrorCode", userAuthTokenParameter, appCodeParameter, centralUserIdParameter, errorCodeParameter);

            errorCode.Value = errorCodeParameter.Value;

            return ret;
        }

        public virtual int SP_DGC_ValidateUser_GetUserSubScriptionDetails(string userMobileNumber, string userPassword, string googleFireBaseToken, string userAccessDevice, string isWebCalling, ObjectParameter centralUserId, ObjectParameter subscriptionId, ObjectParameter subscriptionCode, ObjectParameter userAuthToken)
        {

            var userMobileNumberParameter = new SqlParameter("UserMobileNumber", SqlDbType.VarChar, 500);
            if (string.IsNullOrWhiteSpace(userMobileNumber))
            {
                userMobileNumberParameter.IsNullable = true;
                userMobileNumberParameter.Value = DBNull.Value;
            }
            else
            {
                userMobileNumberParameter.Value = userMobileNumber;
            }

            var userPasswordParameter = new SqlParameter("UserPassword", SqlDbType.VarChar, 500);
            if (string.IsNullOrWhiteSpace(userPassword))
            {
                userPasswordParameter.IsNullable = true;
                userPasswordParameter.Value = DBNull.Value;
            }
            else
            {
                userPasswordParameter.Value = userPassword;
            }

            var googleFireBaseTokenParameter = new SqlParameter("GoogleFireBaseToken", SqlDbType.VarChar, 500);
            if (string.IsNullOrWhiteSpace(googleFireBaseToken))
            {
                googleFireBaseTokenParameter.IsNullable = true;
                googleFireBaseTokenParameter.Value = DBNull.Value;
            }
            else
            {
                googleFireBaseTokenParameter.Value = googleFireBaseToken;
            }

            var userAccessDeviceParameter = new SqlParameter("UserAccessDevice", SqlDbType.VarChar, 500);
            if (string.IsNullOrWhiteSpace(userAccessDevice))
            {
                userAccessDeviceParameter.IsNullable = true;
                userAccessDeviceParameter.Value = DBNull.Value;
            }
            else
            {
                userAccessDeviceParameter.Value = userAccessDevice;
            }

            var isWebCallingParameter = new SqlParameter("IsWebCalling", SqlDbType.VarChar, 500);
            if (string.IsNullOrWhiteSpace(isWebCalling))
            {
                isWebCallingParameter.IsNullable = true;
                isWebCallingParameter.Value = DBNull.Value;
            }
            else
            {
                isWebCallingParameter.Value = isWebCalling;
            }

            var centralUserIdParameter = new SqlParameter("CentralUserId", SqlDbType.BigInt);
            centralUserIdParameter.Direction = System.Data.ParameterDirection.Output;
            centralUserIdParameter.Value = centralUserId != null ? centralUserId.Value : null;

            var subscriptionIdParameter = new SqlParameter("SubscriptionId", SqlDbType.BigInt);
            subscriptionIdParameter.Direction = System.Data.ParameterDirection.Output;
            subscriptionIdParameter.Value = subscriptionId != null ? subscriptionId.Value : null;

            var subscriptionCodeParameter = new SqlParameter("SubscriptionCode", SqlDbType.VarChar, 500);
            subscriptionCodeParameter.Direction = System.Data.ParameterDirection.Output;
            subscriptionCodeParameter.Value = subscriptionCode != null ? subscriptionCode.Value : null;

            var userAuthTokenParameter = new SqlParameter("UserAuthToken", SqlDbType.VarChar, 500);
            userAuthTokenParameter.Direction = System.Data.ParameterDirection.Output;
            userAuthTokenParameter.Value = userAuthToken != null ? userAuthToken.Value : null;


            var retVal = ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("SP_DGC_ValidateUser_GetUserSubScriptionDetails @UserMobileNumber, @UserPassword, @GoogleFireBaseToken, @UserAccessDevice, @IsWebCalling, @CentralUserId OUT, @SubscriptionId OUT, @SubscriptionCode OUT, @UserAuthToken OUT", userMobileNumberParameter, userPasswordParameter, googleFireBaseTokenParameter, userAccessDeviceParameter, isWebCallingParameter, centralUserIdParameter, subscriptionIdParameter, subscriptionCodeParameter, userAuthTokenParameter);

            centralUserId.Value = centralUserIdParameter.Value;
            subscriptionId.Value = subscriptionIdParameter.Value;
            subscriptionCode.Value = subscriptionCodeParameter.Value;
            userAuthToken.Value = userAuthTokenParameter.Value;

            return retVal;

        }
    }
}
