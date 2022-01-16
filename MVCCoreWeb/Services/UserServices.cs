using Microsoft.EntityFrameworkCore;
using MVCCoreWeb.Interfaces;
using MVCCoreWeb.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreWeb.Services
{
    public class UserServices : IUser
    {
        private TestDBContext _context;
        private DbSet<User> table;
        public UserServices()
        {
            _context = new TestDBContext();
            table = _context.Set<User>();
        }
        public User GetById(int UserId)
        {
            return table.Find(UserId);
        }

        public IEnumerable<User> GetUsers()
        {
            return table.ToList();
        }
    }
}
