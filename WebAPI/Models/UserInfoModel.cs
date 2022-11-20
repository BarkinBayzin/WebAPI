using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UserInfoModel
    {
        public string Email { get; set; }
        public int UserID { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string About { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}