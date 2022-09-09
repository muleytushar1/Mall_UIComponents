using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mall_UIComponents.Models
{
    public class Tushar
    {
        [BsonId]
        public int _id { get; set; }
        public string CategoryName { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double ProductPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
