using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SCourse.DataAccess.Context
{
    public class SCourseDbContextFactory
        : IDesignTimeDbContextFactory<CourseDbContext>
    {
        public CourseDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CourseDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=SCourseDb;Trusted_Connection=True;TrustServerCertificate=True;"
            );

            return new CourseDbContext(optionsBuilder.Options);
        }
    }
}