using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class NumberCruncherTest
    {
        [Fact]
        public void SumOfEvenNumbers_Result()
        {
            Assert.Equal(30, NumberUtility.NumberUtility.SumOfEvenNumbers());
        }
    }
}
