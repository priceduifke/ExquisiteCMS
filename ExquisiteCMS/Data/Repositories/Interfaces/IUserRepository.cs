using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExquisiteCMS.Data.Entities;

namespace ExquisiteCMS.Data.Repositories.Interfaces
{
    interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserByEmail(String email);
    }
}
