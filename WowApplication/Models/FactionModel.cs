using MySql.Data.MySqlClient;

namespace WowApplication.Models
{
    public class FactionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Description { get; set; }
        public FactionModel(string name, string capital, string description)
        {
            Name = name;
            Capital = capital;
            Description = description;

        }
        public FactionModel(MySqlDataReader reader)
        {
            Id = reader.GetInt32("factions_id");
            Name = reader.GetString("name");
            Description = reader.GetString("description");
            Capital = reader.GetString("capital");

        }
        public FactionModel(int id, string name, string capital, string description)
        {
            Id = id;
            Name = name;
            Capital = capital;
            Description = description;

        }
        public FactionModel()
        {

        }

    }
}
