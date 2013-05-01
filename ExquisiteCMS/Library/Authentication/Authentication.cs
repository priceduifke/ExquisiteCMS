using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExquisiteCMS.Data;
using ExquisiteCMS.Data.Entities;
using ExquisiteCMS.Data.Repositories;
using ExquisiteCMS.Data.Repositories.Interfaces;
using System.Security.Cryptography;

namespace ExquisiteCMS.Library.Authentication
{
    public class Authentication
    {
        private IUserRepository userRepository;

        public Authentication()
        {
            this.userRepository = new UserRepository(new CMSContext());
        }

        public bool Login(String email, String password) {
            User user = userRepository.GetUserByEmail(email);

            if (user.Password.Equals(Hash(password, user.PasswordSalt)))
            {
                HttpContext.Current.Session["user"] = user;
                return true;
            }

            return false;
        }

        public String Hash(String password, String salt)
        {
            return BCrypt.HashPassword(password, salt);
        }
    }
}