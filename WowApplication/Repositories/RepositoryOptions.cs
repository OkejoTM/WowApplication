using System.ComponentModel.DataAnnotations;

namespace WowApplication.Repositories
{
    public class RepositoryOptions
    {
        public const string Key = "WOW";
        [Required]
        public string ConnectionString { get; set; }


    }
}
