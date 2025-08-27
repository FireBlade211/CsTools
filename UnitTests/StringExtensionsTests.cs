using System.Globalization;

namespace FireBlade.CsTools.UnitTests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNullOrXTest()
        {
            Assert.True("".IsNullOrEmpty());
            Assert.True("   ".IsNullOrWhiteSpace());

            Assert.False("abc".IsNullOrEmpty());
            Assert.False("random test".IsNullOrWhiteSpace());

            Assert.True("some text!!!11!!!1".IsNotNullOrEmpty());
            Assert.False("  ".IsNotNullOrWhiteSpace());
        }

        [Fact]
        public void ParseTest()
        {
            Assert.True("10".TryParseNumber(out int val1));
            Assert.Equal(10, val1);

            Assert.False("abc".TryParseNumber(out double val2));

            Assert.Equal(100.5f, "100.5".ParseNumber<float>(CultureInfo.CreateSpecificCulture("en-us")));
        }

        [Fact]
        public void GetStringTest()
        {
            Assert.Equal("test", "test".ToCharArray().GetString());

            Assert.Equal("🔥🤦‍♂️💾", "🔥🤦‍♂️💾".ToCharArray().GetString()); // More complicated: emojis are multiple unicode characters
        }

        [Fact]
        public void CasingTest()
        {
            Assert.Equal(StringCasing.Title, "Some Random Test".GetCasing());
            Assert.Equal(StringCasing.Upper, "SOME RANDOM TEST".GetCasing());
            Assert.Equal(StringCasing.Lower, "some random test".GetCasing());
            Assert.Equal(StringCasing.Snake, "some_random_test".GetCasing());
            Assert.Equal(StringCasing.Alternating, "SoMe RaNdOm TeSt".GetCasing());
            Assert.Equal(StringCasing.Camel, "someRandomTest".GetCasing());
            Assert.Equal(StringCasing.Pascal, "SomeRandomTest".GetCasing());
            Assert.Equal(StringCasing.Inverse, "sOME rANDOM tEST".GetCasing());
            Assert.Equal(StringCasing.Other, "Ahhu4urwu hfAUu3828audhHS haHAH".GetCasing());

            Assert.Equal("test", "TEST".SetCasing(StringCasing.Lower));
            Assert.Equal("TEST", "test".SetCasing(StringCasing.Upper));
            Assert.Equal("SomeRandomTest", "Some Random Test".SetCasing(StringCasing.Pascal));
            Assert.Equal("Some Random Test", "SomeRandomTest".SetCasing(StringCasing.Title));
            Assert.Equal("someRandomTest", "Some Random Test".SetCasing(StringCasing.Camel));
            Assert.Equal("some_Random_Test", "some Random Test".SetCasing(StringCasing.Snake));
            Assert.Equal("SoMe rAnDoM TeSt", "some Random Test".SetCasing(StringCasing.AlternatingNormal));
            Assert.Equal("sOmE RaNdOm tEsT", "some Random Test".SetCasing(StringCasing.AlternatingReverse));
        }

        [Fact]
        public void IsPalindromeTest()
        {
            Assert.False("test".IsPalindrome());
            Assert.True("Bob".IsPalindrome());
        }
    }
}
