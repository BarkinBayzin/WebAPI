using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AccountController : ApiController
    {
        private const string email = "test@test.com";
        private const string password= "123";

        [EnableCors(origins:"*",headers:"*",methods:"*")] //Cors ayarlarını unutmadan açtım
        public UserInfoModel PostLogin(LoginModel model)
        {
            if (model.Email == email && model.Password ==password)
            {
                UserInfoModel _currentUser = new UserInfoModel();
                _currentUser.Email = model.Email;
                _currentUser.UserID = 1;

                return _currentUser;
            }

            return null;
        }

    }
}
