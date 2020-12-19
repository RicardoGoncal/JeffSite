using System;
using JeffSite.Models;
using Microsoft.EntityFrameworkCore;

namespace JeffSite.Data
{
    public class JeffContext : DbContext
    {
        public JeffContext(DbContextOptions<JeffContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

    }
}
