using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISQLDataAccess _db;

        public PeopleData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT * FROM test_people.user;";
            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"INSERT INTO test_people.user (firstName, lastName, email)
                           VALUES(@FirstName, @LastName, @Email)";

            return _db.SaveData(sql, person);
        }
    }
}
