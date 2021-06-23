using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace ViewBug
{
    public class EntityTypeTest
    {
        [Test]
        public void ViewNameShouldBeCorrectForView()
        {
            var context = MakeContext();

            var entityTypes = context.Model.GetEntityTypes().ToList();

            var jobView = entityTypes.Single(x => x.Name == "ViewBug.Jobs.JobView");

            Assert.NotNull(jobView.GetViewName());
            Assert.Null(jobView.GetTableName());
        }
        [Test]
        public void ViewNameShouldBeCorrectForTable()
        {
            var context = MakeContext();

            var entityTypes = context.Model.GetEntityTypes().ToList();

            var jobView = entityTypes.Single(x => x.Name == "ViewBug.Jobs.Job");

            Assert.Null(jobView.GetViewName());
            Assert.NotNull(jobView.GetTableName());
        }

        private TestDbContext MakeContext()
        {
            return new TestContextFactory().CreateDbContext(System.Array.Empty<string>());
        }
    }
}
