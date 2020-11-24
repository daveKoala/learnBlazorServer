using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DataAccessLibrary
{
    public class MongoDataAccess : IMongoDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "DefaultMongoDB";

        public MongoDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task ListCollections()
        {

            string connectionString = _config.GetConnectionString(ConnectionStringName);

            MongoClient client = new MongoClient(connectionString);

            var dbList = await client.ListDatabaseNamesAsync();

            foreach (var item in dbList.ToList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
