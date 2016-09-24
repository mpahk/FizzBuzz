using Autofac;
using Services.Factories;
using Services.Validators;

namespace Services
{
    public static class Dependencies
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GeneralFizzBuzzService>().As<IFizzBuzzService>();
            builder.RegisterType<FizzBuzzValidator>().As<IFizzBuzzValidator>();
            builder.RegisterType<FizzBuzzStringFactory>().As<IFizzBuzzStringFactory>();

            return builder.Build();
        }
    }
}
