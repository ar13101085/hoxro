using System;
using System.Collections.Generic;
using System.Text;
using Hoxro.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hoxro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<MatterType> MatterType { get; set; }
        public DbSet<Matter> Matter { get; set; }
        public DbSet<MatterStatus> MatterStatuses { get; set; }
        public DbSet<MatterChildStatus> MatterChildStatus { get; set; }
        public DbSet<WorkType> WorkType { get; set; }
        public DbSet<BillingType> BillingTypes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
