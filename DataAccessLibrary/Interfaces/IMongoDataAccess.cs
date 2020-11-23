using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IMongoDataAccess
    {
        string ConnectionStringName { get; set; }

        Task ListCollections();
    }
}