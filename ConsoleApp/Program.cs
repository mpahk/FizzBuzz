using Autofac;
using Services;
using System;

namespace ConsoleApp
{
    class Program
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public Program(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        static void Main(string[] args)
        {
            var container = Dependencies.Register();
            using (var scope = container.BeginLifetimeScope())
            {
                var fizzBuzzService = scope.Resolve<IFizzBuzzService>();
                var program = new Program(fizzBuzzService);
                program.Run();
            }
        }

        void Run()
        {
            var fizzesAndBuzzes = _fizzBuzzService.Generate(15);
            foreach (var item in fizzesAndBuzzes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count1: {fizzesAndBuzzes.Count}");
            Console.Read();

        }
    }
}
