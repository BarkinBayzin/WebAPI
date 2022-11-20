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
    public class CategoryController : ApiController
    {
        [EnableCors(origins:"*",headers:"*",methods:"*")]
        [Route("api/kategorilerim")]
        public IHttpActionResult GetCategoryByUserID(string email, int userID)
        {
            UserInfoModel model = new UserInfoModel
            {
                Email = email,
                UserID = userID
            };

            if(UserManager.IsAuthenticated(model))
            {
                var categories = new List<CategoryModel>()
                {
                    new CategoryModel
                    {
                        CategoryName = "A",
                        Description ="A",
                        UserID = 1
                    },
                    new CategoryModel
                    {
                        CategoryName ="B",
                        Description ="B",
                        UserID = 2
                    }
                };

                return Json(categories.Where(x => x.UserID == model.UserID).ToList());

            }

            return Unauthorized();

        }
    }
}
