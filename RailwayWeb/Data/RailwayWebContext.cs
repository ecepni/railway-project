using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RailwayData;
using RailwayWeb.Data;

namespace RailwayWeb.Data
{
    public class RailwayWebContext : DbContext
    {
        public RailwayWebContext(DbContextOptions<RailwayWebContext> options)
            : base(options)
        {
        }

      
        public DbSet<Wagon> Wagon { get; set; } = default!;

       
        public DbSet<Facility> Facility { get; set; } = default!;

        public DbSet<Line> Line { get; set; } = default!;

        public DbSet<LineSegment> LineSegment { get; set; } = default!;

        public DbSet<Operator> Operator { get; set; } = default!;

        public DbSet<OperatingCompany> OperatingCompany { get; set; } = default!;

        public DbSet<RailwayWeb.Data.WagonType> WagonType { get; set; } = default!;
        public DbSet<RailwayWeb.Data.FacilityType> FacilityType { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Wagon>()
                .ToTable(tb => tb.HasTrigger("trg_CheckWagonWeight"));
        }
    }
}