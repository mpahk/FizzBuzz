using NUnit.Framework;
using Services.Validators;

namespace Services.Tests.Validators
{
    [TestFixture]
    public class FizzBuzzValidatorTests
    {
        private FizzBuzzValidator _fizzBuzzValidator;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzValidator = new FizzBuzzValidator();
        }

        [TestCase(3, false)]
        [TestCase(5, true)]
        public void DividesByFive_Returns_Excpected_Result(int nr, bool excpectedResult)
        {
            // Act
            var result = _fizzBuzzValidator.DividesByFive(nr);

            // Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }

        [TestCase(3, true)]
        [TestCase(5, false)]
        public void DividesByThree_Returns_Excpected_Result(int nr, bool excpectedResult)
        {
            // Act
            var result = _fizzBuzzValidator.DividesByThree(nr);

            // Assert
            Assert.That(result, Is.EqualTo(excpectedResult));
        }
    }
}
