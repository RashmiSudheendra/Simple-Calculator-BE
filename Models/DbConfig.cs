namespace Backend.Models
{
    public class DbConfig : IDbConfig
    {
        public string ConnectionURI { get; set; } = string.Empty;
        public string DbName { get; set; } = string.Empty;
        public string CollectionName { get; set; } = string.Empty;
    }
}
