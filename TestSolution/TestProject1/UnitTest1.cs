using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var ee = 1;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
