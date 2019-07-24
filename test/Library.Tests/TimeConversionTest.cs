using Xunit;

namespace Library.Tests
{
    public class TimeConversionTest
    {
        [Theory]
        [InlineData("12:00:00PM", "12:00:00")]
        [InlineData("12:15:00PM", "12:15:00")]
        [InlineData("01:00:00PM", "13:00:00")]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("11:59:59PM", "23:59:59")]
        public void Conversion_PM_ShouldReturn12to23(string time, string expected)
        {
            var actual = TimeConversion.Converse(time);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12:00:00AM", "00:00:00")]
        [InlineData("12:15:00AM", "00:15:00")]
        [InlineData("01:00:00AM", "01:00:00")]
        [InlineData("01:00:00AM", "01:00:00")]
        [InlineData("07:05:45AM", "07:05:45")]
        [InlineData("11:59:59AM", "11:59:59")]
        public void Conversion_AM_ShouldReturn12to11(string time, string expected)
        {
            var actual = TimeConversion.Converse(time);

            Assert.Equal(expected, actual);
        }
    }
}