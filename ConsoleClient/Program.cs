using Microsoft.Extensions.DependencyInjection;
using MyLib;

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

            var config = provider.GetRequiredService<IConfigurator>();
            config.SetValue("FilePath", "data.csv");

            var commands = provider.GetRequiredService<IPersonDisplayCommands>();

            commands.DisplayAllAdults();

            commands.DisplayAllChildren();
        }
    }
}
