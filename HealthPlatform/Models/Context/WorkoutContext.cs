using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthPlatform.Models.Context
{
    public class WorkoutContext : DbContext
    {
        private IConfigurationRoot _config;

        public WorkoutContext(IConfigurationRoot config, DbContextOptions options)
           : base(options)
        {
            _config = config;
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityType> Types { get; set; }
        public DbSet<Excercise> Exercises { get; set; }
        public DbSet<Gym> Gym { get; set; }
        public DbSet<Running> Running { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:WorkoutContextConnection"]);
        }
    }
}
