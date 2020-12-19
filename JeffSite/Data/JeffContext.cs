using System;
using JeffSite.Models;
using Microsoft.EntityFrameworkCore;

namespace JeffSite.Data
{
    public class JeffContext : DbContext
    {
        public JeffContext()
        {
        }

        public DbSet<User> User { get; set; }

    }
}
