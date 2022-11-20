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
    public class UserController : ApiController
    {
        private const int UserID = 1;
        private const string Email = "test@test.com";
        [EnableCors(origins:"*",headers:"*",methods:"*")] //Cors ayarlarını unutmadan açtım
        public IHttpActionResult GetUserInformation(string email, int userID)
        {
            if (email == Email && userID == UserID)
            {
                UserInfoModel model = new UserInfoModel();
                model.Email = email;
                model.Name = "Barkın";
                model.SurName = "Bayzin";
                model.UserName = "Bayzo";

                return Json(model);
                //dbye bağlanıcalak kullanıcının doğrulu kontrol ediledece...
            }

            return Unauthorized();
        }
    }
}
