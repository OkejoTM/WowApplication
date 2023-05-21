using MySql.Data.MySqlClient;

namespace WowApplication.Models
{
    public class LocationModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Lvl { get; set; }

        public string Continent { get; set; }

        public FactionModel Faction;


        public LocationModel(MySqlDataReader reader)
        {

            Id = int.Parse(reader.GetString("locations_id"));
            Name = reader.GetString("name");
            Lvl = int.Parse(reader.GetString("lvl"));
	        Continent = reader.GetString("continent");
        }

        public LocationModel(int id, string name, int lvl, string continent, FactionModel faction)
        {
            Id = id;
            Name = name;
            Lvl = lvl;
            Continent = continent;
            Faction = faction;
        }

        public LocationModel()
        {

        }

    }
}
