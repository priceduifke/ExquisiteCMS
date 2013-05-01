using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExquisiteCMS.Data.Entities;
using ExquisiteCMS.Data.Repositories.Interfaces;

namespace ExquisiteCMS.Data.Repositories
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private CMSContext context;

        public UserRepository(CMSContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserByEmail(String email)
        {
            return context.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}