using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TideTracker;

namespace server
{
    public partial class TideTrackerContext : DbContext
    {
        public TideTrackerContext()
        {
        }

        public TideTrackerContext(DbContextOptions<TideTrackerContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("server=localhost;database=TideTracker;username=postgres;password=warrior");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<WeatherStation> WeatherStations { get; set; }
    }
}
