using MyLib;

namespace ConsoleClient
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IFileReader _reader;
        private readonly IPersonParser _parser;
        private readonly IConfigurator _config;

        public PersonRepository(IFileReader reader, 
            IPersonParser parser,
            IConfigurator config)
        {
            _reader = reader;
            _parser = parser;
            _config = config;
        }

        public IQueryable<Person> Query()
        {
            var path = _config.GetValue<string>("FilePath");
            var lines = _reader.ReadAllLines("data.csv");
            var persons = lines.Select(l => _parser.ParseFromCsv(l));
            return persons.AsQueryable();
        }
    }
}