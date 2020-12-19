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

        public DbSet<Usuario> User { get; set; }

    }
}
