using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace BooksEmployess.ORM
{

    public class BookDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("author")]
        public string Author { get; set; } = string.Empty;

        [BsonElement("pages")]
        public int Pages { get; set; } = 0;

        [BsonElement("yearofpublication")]
        public string YearOfPublication { get; set; } = string.Empty;

        [BsonElement("image_path")]
        public string ImageLink { get; set; } = string.Empty;
    }

}
