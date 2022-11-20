using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using WebAPI.Models;

namespace WebAPI
{
    public class UserManager
    {
        private const string Email = "test@test.com";
        private const int UserID= 1;

        public static bool IsAuthenticated(UserInfoModel model)
        {
            if (Email == model.Email && UserID == model.UserID)
            {
                return true;
            }
            return false;
        }
    }
}