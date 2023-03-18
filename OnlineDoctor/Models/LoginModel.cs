﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineDoctor.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập Email")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mời nhập mật khẩu")]

        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}