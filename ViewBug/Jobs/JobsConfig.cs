using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ViewBug.Jobs
{
    public class JobsConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("jobs")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
        }
    }
}
