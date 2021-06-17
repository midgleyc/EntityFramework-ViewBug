using Microsoft.EntityFrameworkCore;
using TestSupport.EfHelpers;

namespace ViewBug
{
    public class DbContextBuilder
    {
        public TestDbContext Create()
        {
            return MakeContext();
        }

        private TestDbContext MakeContext()
        {
            var options = MakeOptions();
            var context = new TestDbContext(options);

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            AddViews(context);

            return context;
        }

        private DbContextOptions<TestDbContext> MakeOptions()
        {
            return SqliteInMemory.CreateOptions<TestDbContext>();
        }

        private void AddViews(TestDbContext context)
        {
            context.Database.ExecuteSqlRaw(@"CREATE VIEW jobs_view AS
                                   SELECT DISTINCT j.*
                                   FROM jobs j
                                   WHERE id = 1;");
        }
    }
}
