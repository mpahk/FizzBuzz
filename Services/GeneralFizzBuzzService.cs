using Services.Factories;
using System.Collections.Generic;

namespace Services
{
    public class GeneralFizzBuzzService : IFizzBuzzService
    {
        private readonly IFizzBuzzStringFactory _fizzBuzzStringFactory;

        public GeneralFizzBuzzService(IFizzBuzzStringFactory fizzBuzzStringFactory)
        {
            _fizzBuzzStringFactory = fizzBuzzStringFactory;
        }

        public IReadOnlyCollection<string> Generate(int amount)
        {
            return Generate(1, amount);
        }

        public IReadOnlyCollection<string> Generate(int startingFrom, int amount)
        {
            List<string> collection = new List<string>();
            var end = startingFrom + amount;

            for (int i = startingFrom; i < end; i++)
            {
                collection.Add(_fizzBuzzStringFactory.Create(i));
            }

            return collection;
        }
    }
}
