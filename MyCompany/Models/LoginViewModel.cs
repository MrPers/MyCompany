﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [UIHint("password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
