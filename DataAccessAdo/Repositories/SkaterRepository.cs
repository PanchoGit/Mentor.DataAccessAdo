using System.Data;
using DataAccessAdo.Domains;
using MySqlConnector;

namespace DataAccessAdo.Repositories;

public class SkaterRepository : RepositoryBase, ISkaterRepository
{
    public SkaterRepository(MySqlConnection connection) : base(connection)
    {
    }

    public IEnumerable<Skater> GetAll() {
        var result = new List<Skater>();
        const string sqlString = "SELECT id, name, brand FROM Skaters";

        using var connection = GetConnection();
        connection.Open();
        using var command = new MySqlCommand(sqlString, connection);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            result.Add(new Skater()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Brand = reader.GetString(2),
            });
        }

        return result;
    }
}
