namespace ConsoleClient
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IFileReader _reader;
        private readonly IPersonParser _parser;

        public PersonRepository(IFileReader reader, 
            IPersonParser parser)
        {
            _reader = reader;
            _parser = parser;
        }

        public IQueryable<Person> Query()
        {
            var lines = _reader.ReadAllLines("data.csv");
            var persons = lines.Select(l => _parser.ParseFromCsv(l));
            return persons.AsQueryable();
        }
    }
}