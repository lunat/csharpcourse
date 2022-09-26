using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoApp;

public class Person
{
    [BsonElement("_id")]
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("person_id")]
    public int PersonId { get; set; }
    [BsonElement("name")]
    public string? Name { get; set; }
    [BsonElement("surname")]
    public string? Surname { get; set; }
    [BsonElement("class_id")]
    public int ClassId { get; set; }
    [BsonElement("scores")]
    public List<ScoreObject>? Scores { get; set; }
}

public class ScoreObject
{
    [BsonElement("type")]
    public string? ScoreType { get; set; }
    [BsonElement("score")]
    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Score { get; set; }
}