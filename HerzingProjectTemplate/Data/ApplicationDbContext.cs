using HerzingProjectTemplate.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserProfileInfo> UserProfileInfos { get; set; }
    public DbSet<Nutrition> Nutritions { get; set; }
    
    public DbSet<Workout> Workouts { get; set; }
}

