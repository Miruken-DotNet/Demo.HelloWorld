namespace HelloWorld
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.DependencyInjection;
    using Miruken.Api;
    using Miruken.Callback;
    using Miruken.Register;

    class Program
    {
        static async Task Main(string[] args)
        {
            var handler = new ServiceCollection()
                .AddMiruken(configure => configure
                    .PublicSources(sources => sources.FromEntryAssembly())
                ).Build();

            // var result = await handler.Send(new SayHello());
            // Console.WriteLine(result.Speech);
        }
    }
}