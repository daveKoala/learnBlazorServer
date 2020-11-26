using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.People
{
    public interface IPeopleService
    {
        Task<List<Person>> GetPeople();
        Task InsertPerson(Person person);
    }
}