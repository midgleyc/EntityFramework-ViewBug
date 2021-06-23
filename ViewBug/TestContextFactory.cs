using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ViewBug
{
    public class TestContextFactory : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
            optionsBuilder.UseNpgsql("User Id=postgres;Password=zzz;Server=localhost;Port=5433;Database=zzz;Pooling=true;Integrated Security=True;");

            return new TestDbContext(optionsBuilder.Options);
        }
    }
}
