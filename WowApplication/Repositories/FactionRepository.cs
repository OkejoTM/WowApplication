using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Repositories
{
    public class FactionRepository : IFactionRepository
    {
        private readonly MySqlConnection _connection;
        public FactionRepository(IOptions<RepositoryOptions> options)
        {
            _connection = new MySqlConnection(options.Value.ConnectionString);
        }

        public void AddFaction(FactionModel faction)
        {

            _connection.Open();
            
            new MySqlCommand($"INSERT INTO factions(name, capital, description) VALUES ('{faction.Name}', '{faction.Capital}', '{faction.Description}')", _connection).ExecuteNonQuery();
            
            _connection.Close();

        }

        public void DeleteFaction(int id)
        {
            _connection.Open();

            new MySqlCommand($"DELETE FROM factions WHERE factions_id={id}", _connection).ExecuteNonQuery();

            _connection.Close();
        }

        public IEnumerable<FactionModel> GetAllFactions()
        {
            _connection.Open();

            MySqlDataReader reader = new MySqlCommand("SELECT * FROM factions", _connection).ExecuteReader();
            List<FactionModel> factions = new List<FactionModel>();
            while (reader.Read())
            {
                factions.Add(new FactionModel(reader));
            }
            _connection.Close();
            return factions;    
        }

        public FactionModel GetFactionById(int id)
        {
            _connection.Open();

            MySqlDataReader reader = new MySqlCommand($"SELECT * FROM factions WHERE factions_id = {id}", _connection).ExecuteReader();
            if (reader.Read())
            {
                var faction = new FactionModel(reader);
                _connection.Close();
                return faction;
            }
            throw new Exception();
            
        }

        public void UpdateFaction(FactionModel faction)
        {
            _connection.Open();            
            string query = $"UPDATE factions SET name = '{faction.Name}', capital = '{faction.Capital}', description = '{faction.Description}' WHERE factions_id={faction.Id}";          
            new MySqlCommand(query, _connection).ExecuteNonQuery();
            _connection.Close();
        }

        public FactionModel GetPopularestFaction()
        {
            _connection.Open();

            MySqlDataReader reader = new MySqlCommand($"SELECT factions.factions_id, factions.name, factions.capital, factions.description, COUNT(*) as count_ FROM races LEFT JOIN factions ON factions.factions_id = races.factions_id GROUP BY  factions.factions_id, factions.name, factions.capital, factions.description ORDER BY count_ DESC LIMIT 1", _connection).ExecuteReader();
            if (reader.Read())
            {
                var faction = new FactionModel(reader);
                _connection.Close();
                return faction;
            }
            throw new Exception();
        }
        



    }
}
