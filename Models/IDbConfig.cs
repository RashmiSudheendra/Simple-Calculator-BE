namespace Backend.Models
{
    public interface IDbConfig
    {
            string ConnectionURI { get; set; }
            string DbName { get; set; }
            string CollectionName { get; set; }
    }
}
