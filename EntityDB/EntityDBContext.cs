using Microsoft.EntityFrameworkCore;

namespace Teleperformance._2.EntityDB
{
    public class EntityDBContext: DbContext
    {
        public EntityDBContext(DbContextOptions<EntityDBContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<School> Schools { get; set; }  
        public DbSet<Class> Classes { get; set; } 
    }
}
