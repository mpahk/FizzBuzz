using Services.Validators;

namespace Services.Factories
{
    public class FizzBuzzStringFactory : IFizzBuzzStringFactory
    {
        IFizzBuzzValidator _fizzBuzzValidator;

        public FizzBuzzStringFactory(IFizzBuzzValidator fizzBuzzValidator)
        {
            _fizzBuzzValidator = fizzBuzzValidator;
        }

        private const string _fizz = "Fizz";
        private const string _buzz = "Buzz";
        private string _fizzBuzz = $"{_fizz} {_buzz}";

        public string Create(int number)
        {
            if (_fizzBuzzValidator.DividesByThree(number) && _fizzBuzzValidator.DividesByFive(number))
            {
                return _fizzBuzz;
            }
            if (_fizzBuzzValidator.DividesByThree(number))
            {
                return _fizz;
            }
            if (_fizzBuzzValidator.DividesByFive(number))
            {
                return _buzz;
            }

            return number.ToString();
        }
    }
}
