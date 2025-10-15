
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksEmployess.ORM
{

    [BsonIgnoreExtraElements]
    public class EmployeeDto
    {

        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("firstname")]
        public string? FirstName { get; set; }

        [BsonElement("lastname")]
        public string? LastName { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("age")]
        [BsonRepresentation(BsonType.Int32)]
        public int Age { get; set; } = 0;

        [BsonElement("position")]
        public string? Position { get; set; } = string.Empty;

        [BsonElement("job_description")]
        public string? JobDescription { get; set; } = string.Empty;

        [BsonElement("image")]
        public string? Image { get; set; } = string.Empty;
    }
}
