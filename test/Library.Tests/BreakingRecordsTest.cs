using System.Collections.Generic;
using Xunit;

namespace Library.Tests
{
    public class BreakingRecordsTest
    {
        [Theory]
        [InlineData(new int[]{13, 20, 5, 9, 27}, new int[]{2, 1})]
        [InlineData(new int[]{38, 22, 10, 6, 27}, new int[]{0, 3})]
        public void FindMaxMin_ShouldReturn_MaxMin(int[] scrores, int[] expected){
            //Act
            var actual = BreakingRecords.FindMaxMin(scrores);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}