using Microsoft.EntityFrameworkCore;

namespace comp003bsp25finalprojectvillagranr.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ProgressLog> ProgressLogs { get; set; }
        public DbSet<Goal> Goals { get; set; }
    }
}
