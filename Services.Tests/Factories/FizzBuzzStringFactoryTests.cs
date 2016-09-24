using Moq;
using NUnit.Framework;
using Services.Factories;
using Services.Validators;

namespace Services.Tests.Factories
{
    [TestFixture]
    public class FizzBuzzStringFactoryTests
    {
        private FizzBuzzStringFactory _fizzBuzzStringFactory;
        private IFizzBuzzValidator _fizzBuzzValidator;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzValidator = Mock.Of<IFizzBuzzValidator>();
            _fizzBuzzStringFactory = new FizzBuzzStringFactory(_fizzBuzzValidator);
        }

        [TestCase(true, false, "Fizz")]
        [TestCase(false, true, "Buzz")]
        [TestCase(true, true, "Fizz Buzz")]
        [TestCase(false, false, "1")]
        public void Create_Returns_Excpected_Result(bool dividesByThree, bool dividesByFive, string excpectedResult)
        {
            Mock.Get(_fizzBuzzValidator)
                .Setup(x => x.DividesByThree(It.IsAny<int>()))
                .Returns(dividesByThree);

            Mock.Get(_fizzBuzzValidator)
                .Setup(x => x.DividesByFive(It.IsAny<int>()))
                .Returns(dividesByFive);

            // Act
            var result = _fizzBuzzStringFactory.Create(1);

            // Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }
    }
}
