using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Tests
{
    public class ServiceClassTests
    {
        [Fact]
        public void DoSomethingWhenPositiveReturnsOne()
        {
            // Arrange
            var expected = 1;
            var service = new ServiceClass();

            // Act
            int actual = service.DoSomething("positive");

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void DoSomethingWhenNegativeReturnsMinusOne()
        {
            // Arrange
            var expected = -1;
            var service = new ServiceClass();

            // Act
            int actual = service.DoSomething("negative");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("positive", 1)]
        [InlineData("negative", -1)]
        [InlineData("other", 0)]
        public void DoSomethingForInputReturnsExpected(string input, int expected)
        {
            // Arrange
            var service = new ServiceClass();

            // Act
            int actual = service.DoSomething(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
