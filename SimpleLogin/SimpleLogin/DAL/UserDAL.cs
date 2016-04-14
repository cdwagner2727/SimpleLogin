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
    }
}