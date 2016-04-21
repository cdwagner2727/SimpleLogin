using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SimpleLogin.Models;

namespace SimpleLogin.DAL
{
    public class UserDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("tblUsers");
        }

        public DbSet<User> Users { get; set; }

        //returns true if username is unique; false otherwise
        public bool IsUnique(User u)
        {
            if (this.Users.Any(x => x.Username == u.Username))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public User GetUserByUsername(string username) 
        {
            return this.Users.First(n => n.Username == username);
        }

        public bool IsValid(string username, string password)
        {
            bool isValid = false;
            if (this.Users.Any(x => x.Username == username))
            {
                User x = this.Users.First(n => n.Username == username);
                if (x.Password == password)
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}