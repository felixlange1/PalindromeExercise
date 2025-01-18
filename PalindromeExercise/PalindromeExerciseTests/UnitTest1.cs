using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("madam", true)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("civic", true)]
        [InlineData("level", true)]
        [InlineData("coke", false)]
        public void PalindromeTest(string word, bool expected)
        {
                //Arrange
                var challenger = new WordSmith();
                 
                //Act
                var actual = challenger.IsAPalindrome(word);
                
                //Assert
                Assert.Equal(expected, actual);
        }
    }
}
