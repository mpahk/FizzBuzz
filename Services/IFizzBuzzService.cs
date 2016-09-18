using System.Collections.Generic;

namespace Services
{
    public interface IFizzBuzzService
    {
        IReadOnlyCollection<string> Generate(int amount);
        IReadOnlyCollection<string> Generate(int startingFrom, int amount);
    }
}
