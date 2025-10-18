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

        [BsonElement("pagecount")]
        public int Pages { get; set; } = 0;

        [BsonElement("price")]
        public double YearOfPublication { get; set; } = 0.0;

        [BsonElement("image")]
        public string ImageLink { get; set; } = string.Empty;
    }

}
