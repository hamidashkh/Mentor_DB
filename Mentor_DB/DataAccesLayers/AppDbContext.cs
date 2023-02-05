using Mentor_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor_DB.DataAccesLayers
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<HomePage> homePages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
    }
}
