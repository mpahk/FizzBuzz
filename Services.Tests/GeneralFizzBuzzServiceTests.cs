using Moq;
using NUnit.Framework;
using Services.Factories;

namespace Services.Tests
{
    [TestFixture]
    public class GeneralFizzBuzzServiceTests
    {
        private IFizzBuzzStringFactory _fizzBuzzStringFactory;
        private GeneralFizzBuzzService _fizzBuzzService;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzStringFactory = Mock.Of<IFizzBuzzStringFactory>();
            _fizzBuzzService = new GeneralFizzBuzzService(_fizzBuzzStringFactory);
        }

        [Test]
        public void Generate_Amount_Returns_Specified_Amount_Of_Results()
        {

            // Act
            var result = _fizzBuzzService.Generate(3);

            // Assert
            Mock.Get(_fizzBuzzStringFactory)
                .Verify(x => x.Create(It.IsAny<int>()), Times.Exactly(3));
            Assert.That(result.Count, Is.EqualTo(3));
        }

        [Test]
        public void Generate_StartingFrom_Amount_Returns_Specified_Amount_Of_Results()
        {

            // Act
            var result = _fizzBuzzService.Generate(0, 3);

            // Assert
            Mock.Get(_fizzBuzzStringFactory)
                .Verify(x => x.Create(It.IsAny<int>()), Times.Exactly(3));
            Assert.That(result.Count, Is.EqualTo(3));
        }
    }
}
