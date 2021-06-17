using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ViewBug.Jobs
{
    public class JobViewsConfig : IEntityTypeConfiguration<JobView>
    {
        public void Configure(EntityTypeBuilder<JobView> builder)
        {
            builder.ToView("jobs_for_users")
                //.ToTable(null) // comment or uncomment this row to see the test failure or success
                .HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
        }
    }
}
