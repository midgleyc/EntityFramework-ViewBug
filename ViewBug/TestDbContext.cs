using Microsoft.EntityFrameworkCore;
using ViewBug.Extensions;
using ViewBug.Jobs;

namespace ViewBug
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JobView> JobViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new JobsConfig());
            builder.ApplyConfiguration(new JobViewsConfig());

            builder.EnsureSnakeCase();
        }
    }
}
