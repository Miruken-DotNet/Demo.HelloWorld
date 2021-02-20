namespace HelloWorld
{
    using Microsoft.Extensions.DependencyInjection;
    using Miruken.Callback;
    using Miruken.Register;

    class Program
    {
        static void Main(string[] args)
        {
            var handler = new ServiceCollection()
                .AddMiruken(configure => configure
                    .PublicSources(sources => sources.FromEntryAssembly())
                ).Build();

            handler.Handle(new SayHello());
        }
    }
}