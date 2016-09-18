namespace Services.Validators
{
    public interface IFizzBuzzValidator
    {
        bool DividesByFive(int number);
        bool DividesByThree(int number);
    }
}