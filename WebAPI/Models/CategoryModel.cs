using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class CategoryModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
    }
}