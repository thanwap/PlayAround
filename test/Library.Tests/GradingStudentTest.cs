using System.Collections.Generic;
using Xunit;

namespace Library.Tests
{
    public class GradingStudentTest
    {
        [Fact]
        public void RoundGrade_NotPassed_ShouldReturnSameValue(){
            //Arrange
            var grades = new List<int>(){0, 1, 2, 3, 9, 11, 26, 33, 37};
            var expected = new List<int>(){0, 1, 2, 3, 9, 11, 26, 33, 37};

            //Act
            var actual = GradingStudent.RoundGrade(grades);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RoundGrade_PassedAndDifOfMultipleNumberAndGradeLessThan3_ShouldRoundUp(){
            //Arrange
            var grades = new List<int>(){38, 39, 43, 44, 53, 98, 99};
            var expected = new List<int>(){40, 40, 45, 45, 55, 100, 100};

            //Act
            var actual = GradingStudent.RoundGrade(grades);

            //Assert
            Assert.Equal(expected, actual);
        }

        public void RoundGrade_PassedAndDifOfMultipleNumberAndGradeMorethan2_ShouldNotRound(){
            //Arrange
            var grades = new List<int>(){40, 41, 52, 91, 97};
            var expected = new List<int>(){40, 41, 52, 91, 97};

            //Act
            var actual = GradingStudent.RoundGrade(grades);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(43, 45)]
        [InlineData(46, 50)]
        [InlineData(99, 100)]
        public void FindMultiNumber_ShouldGetMultiNumber(int number, int expected){
            var actual = GradingStudent.FindMultiNumber(number);

            Assert.Equal(expected, actual);
        }

        
    }
}