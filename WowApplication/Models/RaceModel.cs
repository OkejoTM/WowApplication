using MySql.Data.MySqlClient;

namespace WowApplication.Models
{
    public class RaceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string StartLocation { get; set; }
        public string Description { get; set; }
        public FactionModel Faction { get; set; }
        public RaceModel(int id,string name, string startLocation, string description, FactionModel faction)
        {
            Id = id;
            Name = name;
            StartLocation = startLocation;
            Description = description;
            Faction = faction;
        }

        public RaceModel(MySqlDataReader reader)
        {
            Id = reader.GetInt32("races_id");
            Name = reader.GetString("name");
            StartLocation = reader.GetString("start_location");
            Description = reader.GetString("description");            
        }

        public RaceModel(string name, string startLocation, string description, FactionModel faction)
        {            
            Name = name;
            StartLocation = startLocation;
            Description = description;
            Faction = faction;
        }
        public RaceModel()
        {

        }       

    }


}
