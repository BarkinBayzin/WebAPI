﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class LoginModel
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}