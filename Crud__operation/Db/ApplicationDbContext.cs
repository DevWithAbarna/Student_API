using Crud__operation.Model;
using Microsoft.EntityFrameworkCore;

namespace Crud__operation.Db
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Student>Students { get; set; }

        public DbSet<Staff> Staffs { get; set; }
    }
}
