using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Backend.Models
{
    public class Calculation
    {
    [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("number1")]
        public int Number1 { get; set; }

        [BsonElement("number2")]
        public int Number2 { get; set; }

        [BsonElement("operator")]
        public string Operation { get; set; } = null!;

        [BsonElement("result")]
        public int Result { get; set; }

        [BsonElement("createdOn")]
        public DateTime CreatedOn { get; set; } 

    } 
}
