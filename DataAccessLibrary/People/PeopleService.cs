using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.People
{
    public class PeopleService : IPeopleService
    {
        private readonly ISQLDataAccess _db;

        public PeopleService(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<Person>> GetPeople()
        {
            string sql = "SELECT * FROM test_people.user;";
            return _db.LoadData<Person, dynamic>(sql, new { });
        }

        public Task InsertPerson(Person person)
        {
            string sql = @"INSERT INTO test_people.user (firstName, lastName, email)
                           VALUES(@FirstName, @LastName, @Email)";

            return _db.SaveData(sql, person);
        }
    }
}
