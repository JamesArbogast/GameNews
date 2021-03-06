using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace GameStock.Models
{
    public class LoginUser
    {
        [NotMapped] // don't add table to db
        [Required(ErrorMessage = "is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(8, ErrorMessage = "must be at least 8 characters")]
        [DataType(DataType.Password)] // auto fills input type attr
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
    }
}