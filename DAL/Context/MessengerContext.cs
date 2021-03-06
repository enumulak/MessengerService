using Microsoft.EntityFrameworkCore;
using Models.Messengers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class MessengerContext : DbContext
    {
        public MessengerContext([JetBrains.Annotations.NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Pool> Pools { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
