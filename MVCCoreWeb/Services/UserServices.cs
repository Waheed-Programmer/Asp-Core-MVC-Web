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


        public string Delete(User obj)
        {
            try
            {
                table.Remove(obj);
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
            return "";
        }

        

        public string Insert(User obj)
        {
            try
            {
                table.Add(obj);
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
            return "";
        }

       

        public string Update(User obj)
        {
            try
            {
                table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
            return "";
        }
        public string SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
            return "";
        }
    }
}
