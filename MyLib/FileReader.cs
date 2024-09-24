namespace ConsoleClient
{
    public class FileReader : IFileReader
    {
        public IEnumerable<string> ReadAllLines(string path)
        {
            var lines = File.ReadAllLines(path);
            return lines;
        }
    }
}