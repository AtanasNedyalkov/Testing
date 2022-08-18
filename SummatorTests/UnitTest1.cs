using NUnit.Framework;

namespace SummatorTests
{
    public class SummatorTests
    {
        public void Test_SumNumbers()
        {
            var sum = Summator.Sum(new[]int{ 1, 2 });
            Assert.AreEqual(3, sum);
        }
    }
}