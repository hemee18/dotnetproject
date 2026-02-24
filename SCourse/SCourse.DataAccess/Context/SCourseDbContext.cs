using Microsoft.EntityFrameworkCore;
using SCourse.Entities;

namespace SCourse.DataAccess.Context
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            : base(options) { }

        public DbSet<Course> Courses => Set<Course>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasKey(c => c.SCourseId);

            modelBuilder.Entity<Course>()
                .Property(c => c.CourseName)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Course>()
                .Property(c => c.CourseCode)
                .HasMaxLength(50);

            modelBuilder.Entity<Course>()
                .Property(c => c.Fee)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}