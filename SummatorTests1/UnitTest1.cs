using NUnit.Framework;

namespace SummatorTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_SumTwoNumbers()
        {
            var sum = Summator.Sum(new int[] { 1, 2 });
            Assert.AreEqual(3, sum);
        }
    }
}