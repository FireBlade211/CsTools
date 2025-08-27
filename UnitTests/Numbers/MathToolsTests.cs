using FireBlade.CsTools.Numbers;

namespace FireBlade.CsTools.UnitTests.Numbers
{
    public class MathToolsTests
    {
        [Fact]
        public void MapTest()
        {
            var source = new Range<int>(1, 10);
            var output = new Range<int>(11, 20);

            var mapped = MathTools.Map(5, source, output);

            Assert.Equal(15, mapped);

            Assert.Equal(11, MathTools.Map(1, source, output));

            Assert.Equal(20, MathTools.Map(10, source, output));

            Assert.Equal(68, MathTools.Map(-32, new Range<int>(-100, 0), new Range<int>(0, 100)));
        }

        [Fact]
        public void ModTest()
        {
            Assert.Equal(0, MathTools.Mod(10, 2));
        }

        [Fact]
        public void IsEvenOddTest()
        {
            Assert.True(MathTools.IsEven(8));
            Assert.False(MathTools.IsEven(5));

            Assert.True(MathTools.IsOdd(3));
            Assert.False(MathTools.IsOdd(6));
        }
    }
}
