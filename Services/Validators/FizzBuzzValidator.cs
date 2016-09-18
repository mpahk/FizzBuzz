namespace Services.Validators
{
    public class FizzBuzzValidator : IFizzBuzzValidator
    {
        public bool DividesByThree(int number) => DividesByN(number, 3);

        public bool DividesByFive(int number) => DividesByN(number, 5);

        private bool DividesByN(int number, int dividiable) => number % dividiable == 0;
    }
}
