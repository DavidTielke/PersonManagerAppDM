using ConsoleClient;
using Microsoft.AspNetCore.Mvc;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonManager _manager;

        public PersonsController(IPersonManager manager)
        {
            _manager = manager;
        }

        [HttpGet()]
        [Route("/Persons/Adults")]
        public IEnumerable<Person> GetAllAdults()
        {
            return _manager.GetAllAdults();
        }
        
        [HttpGet()]
        [Route("/Persons/Children")]
        public IEnumerable<Person> GetAllChildren()
        {
            return _manager.GetAllChildren();
        }
    }
}
