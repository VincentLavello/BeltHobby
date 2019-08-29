using System.Collections.Generic;

using System;
using System.ComponentModel.DataAnnotations;
namespace BeltExam.Models
{
    public class Login
    {

        [Required]
        [EmailAddress]
        public string Email{ get; set; }
        [Required]
        [MinLength(8)] 
        [DataType(DataType.Password)]
        public string Password{ get; set; }

        public Login(){}
        public Login(string email, string pwd)
        {
            Email=email; 
            Password=pwd;
        }
    }
}
