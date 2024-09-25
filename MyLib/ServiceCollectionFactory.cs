using Microsoft.Extensions.DependencyInjection;
using MyLib;

namespace ConsoleClient;

public class ServiceCollectionFactory
{
    public IServiceCollection Initialize(IServiceCollection collection)
    {
        collection.AddTransient<IPersonManager, PersonManager>();
        collection.AddTransient<IPersonRepository, PersonRepository>();
        collection.AddTransient<IPersonParser, PersonParser>();
        collection.AddTransient<IFileReader, FileReader>();
        collection.AddSingleton<IConfigurator, MemoryConfigurator>();

        return collection;
    }
}