namespace ConsoleClient;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string path);
}