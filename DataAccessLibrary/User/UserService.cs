using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace DataAccessLibrary.User
{
    public class UserService : IUserService
    {
        private IMongoCollection<User> _userColection;

        public UserService() // Here will be the mongo client, but how to inject it INSIDE this data access library. So the main todo3 part only injects the services needed not services AND clients seperatly
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
