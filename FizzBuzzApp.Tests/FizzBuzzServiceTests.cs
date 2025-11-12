using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _sut;

        public FizzBuzzServiceTests()
        {
            _sut = new();
        }

        [Fact]
        public void Fizz_Method_Should_Return_Fizz()
        {
            //Arrange
            var expected = "Fizz";

            //Act
            var result = _sut.Fizz();

            //Assert
            Assert.Equal(expected, result);

        }


        [Fact]
        public void Buzz_Method_Should_Return_Buzz()
        {
            //Arrange
            var expected = "Buzz";

            //Act
            var result = _sut.Buzz();
            //Assert

            Assert.Equal(expected, result);

        }

        [Fact]
        public void FizzBuzz_Method_Should_Return_FizzBuzz()
        {
            //Arrange
            var expected = "FizzBuzz";

            //Act
            var result = _sut.FizzBuzz();

            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void GetFizzBuzzResult_Should_Return_Correct_Result()
        {

            //Arrange
            var limit = 16;
            var expected = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };


            //Act
            var result = _sut.GetFizzBuzzResult(limit);


            //Assert 
            Assert.Equal(expected, result);

        }



    }
}
