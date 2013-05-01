using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExquisiteCMS.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public String PasswordSalt { get; set; }

        public DateTime PasswordChangedDate { get; set; }

        public DateTime LastLoginFailureDate { get; set; }

        public DateTime CreateDate { get; set; }   
    }
}