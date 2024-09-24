namespace ConsoleClient;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLine);
}