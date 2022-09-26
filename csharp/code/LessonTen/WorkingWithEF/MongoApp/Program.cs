using System.Text.Json;
using MongoApp;
using MongoDB.Bson;
using MongoDB.Driver;
using static System.Console;

var connectionString = @"mongodb://localhost:27017";
var client = new MongoClient(connectionString);

var database = client.GetDatabase("course");
//var collection = database.GetCollection<BsonDocument>("persons");
var collection = database.GetCollection<Person>("persons");

var filter = Builders<Person>.Filter.Empty;
//var filter = Builders<Person>
//    .Filter
//    .Eq(x => x.Name, "Mike");

var sort = Builders<Person>.Sort.Ascending("name");

var result = await collection
    //.Find(filter)
    .Find(_ => true)
    .Sort(sort)
    .ToListAsync();

foreach (var item in result)
{
    WriteLine($"{item.Id}: {item.Name}" +
              $", {JsonSerializer.Serialize(item.Scores)}");
}

#region Insert Documents
//var documents = new List<Person>
//{
//    new Person
//    {
//        PersonId = 10001,
//        Name = "Claire",
//        Surname = "Robinson",
//        ClassId = 480,
//        Scores = new List<ScoreObject>
//        {
//            new()
//            {
//                ScoreType = "exam",
//                Score = 98.2m
//            },
//            new()
//            {
//                ScoreType = "quiz",
//                Score = 74.9m
//            },
//            new()
//            {
//                ScoreType = "homework",
//                Score = 70.9m
//            },
//        }
//    },
//    new Person
//    {
//        PersonId = 10002,
//        Name = "Mike",
//        Surname = "Bell",
//        ClassId = 480,
//        Scores = new List<ScoreObject>
//        {
//            new()
//            {
//                ScoreType = "exam",
//                Score = 70.6m
//            },
//            new()
//            {
//                ScoreType = "quiz",
//                Score = 74.9m
//            },
//            new()
//            {
//                ScoreType = "homework",
//                Score = 89.9m
//            }
//        }
//    }
//};

//await collection.InsertManyAsync(documents);
//WriteLine("Inserted documents...");
//foreach (var d in documents)
//{
//    WriteLine($"Inserted Document: {d.Id}");
//}

//var document = new Person
//{
//    PersonId = 10000,
//    Name="Lisa",
//    Surname = "Grant",
//    ClassId = 480,
//    Scores = new List<ScoreObject>
//    {
//        new()
//        {
//            ScoreType = "exam",
//            Score = 88.1m
//        },
//        new()
//        {
//            ScoreType = "quiz",
//            Score = 74.9m
//        },
//        new()
//        {
//            ScoreType = "homework",
//            Score = 89.9m
//        },
//        new()
//        {
//            ScoreType = "homework",
//            Score = 82.1m
//        }
//    }
//};
//
//await collection.InsertOneAsync(document);
//
//WriteLine($"Inserted document: {document.Id}");
#endregion Insert Documents

#region Get First Document
//WriteLine("Read first document:");
//var firstDocument = collection
//    .Find(new BsonDocument())
//    .FirstOrDefault();
//WriteLine(firstDocument.ToString());
#endregion

#region Insert first document
/*
var document = new BsonDocument
{
    {"person_id", 10000},
    {"name", "Lisa"},
    {"surname", "Grant"},
    {"scores", new BsonArray
    {
        new BsonDocument{ {"type","exam"}, {"score", 88.1} },
        new BsonDocument{ {"type","quiz"}, {"score", 74.9} },
        new BsonDocument{ {"type","homework"}, {"score", 89.9} },
        new BsonDocument{ {"type", "homework" }, {"score", 82.1} },
    }},
    {"class_id", 480}
};

//collection.InsertOne(document);
await collection.InsertOneAsync(document);
*/
#endregion

//var dbList = client.ListDatabases().ToList();
//WriteLine("List of databases:");
//
//foreach (var db in dbList)
//{
//    WriteLine(db);
//}