using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Result> Result { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
