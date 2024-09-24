namespace ConsoleClient
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;
        private readonly IPersonParser _parser;

        public PersonManager(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Person> GetAllAdults()
        {
            var adults = _repository
                .Query()
                .Where(p => p.Age >= 18);
            return adults;
        }
        
        public IQueryable<Person> GetAllChildren()
        {
            var children = _repository
                .Query()
                .Where(p => p.Age < 18);
            return children;
        }
    }
}