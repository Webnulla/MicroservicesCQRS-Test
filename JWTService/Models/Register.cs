﻿using System.ComponentModel.DataAnnotations;

namespace JWTService.Models
{
    public class Register
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set;}
    }
}
