using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext(DbContextOptions options) : base(options)
        {
        }
    }
}
