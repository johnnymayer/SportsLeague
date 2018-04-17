using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SportsLeague.Models
{
    public class SportsLeagueDbContext : DbContext
    {
        public SportsLeagueDbContext()
        {
        }

        public DbSet<Division> Divisions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=SportsLeague;uid=root;pwd=root;");
        }

        public SportsLeagueDbContext(DbContextOptions<SportsLeagueDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
