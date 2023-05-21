using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly MySqlConnection _connection;

        public LocationRepository(IOptions<RepositoryOptions> options)
        {
            _connection = new MySqlConnection(options.Value.ConnectionString);
        }


        public LocationModel GetPopulaterstLocation()
        {
            _connection.Open();

            MySqlDataReader reader = new MySqlCommand("SELECT locations_id, name, lvl, continent, MAX(lvl) as lvl_ FROM locations GROUP BY locations_id, name, lvl, continent ORDER BY lvl_ DESC LIMIT 1", _connection).ExecuteReader();

            if (reader.Read())
            {
                var location = new LocationModel(reader);
                _connection.Close();                
                return location;
            }
            throw new Exception();

        }

    }
}
