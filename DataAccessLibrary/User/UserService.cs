using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace DataAccessLibrary.User
{
    public class UserService : IUserService
    {
        private IMongoCollection<User> _userColection;

        public UserService()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var dataBase = client.GetDatabase("Books");

            _userColection = dataBase.GetCollection<User>("users");
        }

        public IEnumerable<User> Get()
        {

            return _userColection.Find("{}").ToList();
        }

        public IEnumerable<User> Get(string p)
        {

            return _userColection.Find(s => s.FirstName == p).ToList();
        }
    }
}
