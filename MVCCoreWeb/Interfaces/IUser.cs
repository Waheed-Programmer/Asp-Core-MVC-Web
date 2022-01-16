using MVCCoreWeb.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> GetUsers();
        User GetById(int UserId);
    }
}
