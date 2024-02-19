using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagerWebApp.Models;

namespace ManagerWebApp.Data
{
    public class ManagerWebAppContext : DbContext
    {
        public ManagerWebAppContext (DbContextOptions<ManagerWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<ManagerWebApp.Models.Manager> Manager { get; set; } = default!;
    }
}
