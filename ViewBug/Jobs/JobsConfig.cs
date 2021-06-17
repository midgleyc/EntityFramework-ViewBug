using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ViewBug.Jobs
{
    public class JobsConfig : IEntityTypeConfiguration<JobView>
    {
        public void Configure(EntityTypeBuilder<JobView> builder)
        {
            builder.ToTable("jobs")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
        }
    }
}
