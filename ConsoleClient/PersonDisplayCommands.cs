namespace ConsoleClient;

public class PersonDisplayCommands : IPersonDisplayCommands
{
    private IPersonManager _personManager;

    public PersonDisplayCommands(IPersonManager personManager)
    {
        _personManager = personManager;
    }

    public void DisplayAllAdults()
    {
        var adults = _personManager.GetAllAdults().ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }

    public void DisplayAllChildren()
    {
        var children = _personManager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(a => Console.WriteLine(a.Name));
    }
}