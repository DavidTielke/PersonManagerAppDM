using ConsoleClient;
using FluentAssertions;

namespace UnitTests
{
    [TestFixture]
    public class PersonParserTests
    {
        [Test]
        public void Test1()
        {
            var parser = new PersonParser();
            var line = "1,Test,23";

            var person = parser.ParseFromCsv(line);

            person.Should().NotBe(null);
            person.Id.Should().Be(1);
            person.Name.Should().Be("Test");
            person.Age.Should().Be(23);
        }
    }
}