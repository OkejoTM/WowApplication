using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using WowApplication.Models;
using WowApplication.Repositories.Interfaces;

namespace WowApplication.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private readonly MySqlConnection _connection;

        public RaceRepository(IOptions<RepositoryOptions> options)
        {
            _connection = new MySqlConnection(options.Value.ConnectionString);
        }

        public void AddRace(RaceModel race)
        {
            _connection.Open();
            int faction_id = (int)new MySqlCommand($"SELECT factions_id FROM factions WHERE name = '{race.Faction.Name}'", _connection).ExecuteScalar();
            new MySqlCommand($"INSERT INTO races (name, start_location, description, factions_id) VALUES ( '{race.Name}', '{race.StartLocation}', '{race.Description}', {faction_id} )", _connection).ExecuteNonQuery();

            _connection.Close();
        }

        public void DeleteRace(int id)
        {
            _connection.Open();

            new MySqlCommand($"DELETE FROM races WHERE races_id = {id}", _connection).ExecuteNonQuery();

            _connection.Close();
        }

        public IEnumerable<RaceModel> GetAllRaces()
        {
            _connection.Open();

            List<RaceModel> races = new List<RaceModel>();
            MySqlDataReader reader = new MySqlCommand("SELECT * FROM races", _connection).ExecuteReader();

            while (reader.Read())
            {
                races.Add(new RaceModel(reader));
            }

            _connection.Close();

            foreach(RaceModel race in races)
            {
                _connection.Open();
                MySqlDataReader reader2 = new MySqlCommand($"SELECT * from factions WHERE factions_id = (SELECT races.factions_id FROM races WHERE races_id = {race.Id})", _connection).ExecuteReader();
                if (reader2.Read())
                {
                    FactionModel faction = new FactionModel(reader2);
                    race.Faction = faction;

                }
                _connection.Close();
                
            }

            return races;
        }

        public RaceModel GetRaceById(int id)
        {
            _connection.Open();
            MySqlDataReader reader = new MySqlCommand($"SELECT * FROM races WHERE races_id = {id}", _connection).ExecuteReader();           
            RaceModel race = new RaceModel();

            if (reader.Read())
            {
                race = new RaceModel(reader);

            }

            _connection.Close();

            _connection.Open();
            MySqlDataReader reader2 = new MySqlCommand($"SELECT * FROM factions WHERE factions_id = (SELECT races.factions_id FROM races WHERE races_id = {id})", _connection).ExecuteReader();
            FactionModel faction = new FactionModel();
            if (reader2.Read())
            {
                faction = new FactionModel(reader2);
            }
            race.Faction = faction;

            return race;
            
        }

        public void UpdateRace(RaceModel race)
        {
            _connection.Open();
            int faction_id = (int)new MySqlCommand($"SELECT factions_id FROM factions WHERE name = '{race.Faction.Name}'", _connection).ExecuteScalar();

            new MySqlCommand($"UPDATE races SET name = '{race.Name}', start_location = '{race.StartLocation}', description = '{race.Description}', factions_id = '{faction_id}' WHERE races_id = {race.Id} ", _connection).ExecuteNonQuery();

            _connection.Close();
        }

        public RaceModel GetPopularestStartLocationByFraction()
        {
            _connection.Open();

            MySqlDataReader reader = new MySqlCommand($"SELECT races_id, name, start_location, description COUNT(*) as count_  FROM races LEFT JOIN factions ON factions.factions_id = races.factions_id GROUP BY races_id, name, start_location, description  ORDER BY count_ DESC LIMIT 1;", _connection).ExecuteReader();
            if (reader.Read())
            {
                var race = new RaceModel(reader);
                _connection.Close();
                return race;
            }
            throw new Exception();
        }


    }
}
