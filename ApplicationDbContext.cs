using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Authenticate.Data;

namespace Authenticate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Authenticate.Data.Employees> Employees { get; set; }
        public DbSet<Authenticate.Data.Departments> Departments { get; set; }
    }
}
