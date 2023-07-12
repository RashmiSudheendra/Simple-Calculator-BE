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
        public double Number1 { get; set; }

        [BsonElement("number2")]
        public double Number2 { get; set; }

        [BsonElement("operator")]
        public string Operation { get; set; } = null!;

        [BsonElement("result")]
        public double Result { get; set; }

        [BsonElement("createdOn")]
        public DateTime CreatedOn { get; set; } 

    } 
}
