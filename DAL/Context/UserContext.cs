using Microsoft.EntityFrameworkCore;
using Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class UserContext : DbContext
    {
        public UserContext([JetBrains.Annotations.NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
