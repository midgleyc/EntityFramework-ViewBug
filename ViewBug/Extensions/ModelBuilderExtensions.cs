using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ViewBug.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void EnsureSnakeCase(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entity in builder.Model.GetEntityTypes())
            {
                if (entity.GetViewName() != null)
                {
                    continue;
                }

                entity.SetTableName(entity.GetTableName().ToSnakeCase());

                foreach (IMutableProperty property in entity.GetProperties())
                {
                    property.SetColumnName(property.Name.ToSnakeCase());
                }

                foreach (IMutableKey key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToSnakeCase());
                }

                foreach (IMutableForeignKey key in entity.GetForeignKeys())
                {
                    key.SetConstraintName(key.GetConstraintName().ToSnakeCase());
                }

                foreach (IMutableIndex index in entity.GetIndexes())
                {
                    index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
                }
            }
        }
    }
}
