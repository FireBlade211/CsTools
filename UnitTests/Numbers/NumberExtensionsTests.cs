using FireBlade.CsTools.Numbers;

namespace FireBlade.CsTools.UnitTests.Numbers
{
    public class NumberExtensionsTests
    {
        [Fact]
        public void IsInRangeTest()
        {
            int val1 = 5;
            bool inRange1 = val1.IsInRange(0, 10);

            Assert.True(inRange1);

            float val2 = 64.33f;
            bool isInRange2 = val2.IsInRange(8, 32);

            Assert.False(isInRange2);

            double val3 = 36.164714717771;

            bool isInRange3 = val3.IsInRange(32f, 64f); // test with other input types

            Assert.True(isInRange3);

            Range<int> range = new Range<int>(5, 10);

            bool isInRange4 = range.IsInRange(8);

            Assert.True(isInRange4);
        }
    }
}
