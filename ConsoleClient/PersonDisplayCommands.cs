namespace ConsoleClient;

public class PersonDisplayCommands
{
    private PersonManager _personManager;

    public PersonDisplayCommands()
    {
        _personManager = new PersonManager();
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