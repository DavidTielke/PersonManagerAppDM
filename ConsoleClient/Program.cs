using Microsoft.Extensions.DependencyInjection;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var collection = new ServiceCollection();
            new ServiceCollectionFactory().Initialize(collection);
            collection.AddTransient<IPersonDisplayCommands, PersonDisplayCommands>();

            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonDisplayCommands>();

            commands.DisplayAllAdults();

            commands.DisplayAllChildren();
        }
    }
}
