using NUnit.Framework;

namespace ViewBug
{
    public class CreateDbTest
    {
        [Test]
        public void ShouldCreateDatabase()
        {
            new DbContextBuilder().Create();
        }
    }
}
