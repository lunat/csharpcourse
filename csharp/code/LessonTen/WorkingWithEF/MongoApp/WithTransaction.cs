using MongoDB.Bson;
using MongoDB.Driver;

public static class WithTransaction
{
    public static void Run()
    {
        var connectionString = @"mongodb://localhost:27017";

        var client = new MongoClient(connectionString);

        var database1 = client.GetDatabase("course");
        var collection1 = database1
            .GetCollection<BsonDocument>("users")
            .WithWriteConcern(WriteConcern.WMajority);

        collection1.InsertOne(new BsonDocument("abc", 0));

        using (var session = client.StartSession())
        {
            var transactionOptions = new TransactionOptions(
                readPreference: ReadPreference.Primary
                , readConcern: ReadConcern.Local
                , writeConcern: WriteConcern.WMajority);

            var cancellationToken = CancellationToken.None;

            var result = session.WithTransaction(
                (s, ct) =>
                {
                    collection1.InsertOne(s, new BsonDocument("abc", 1));
                    return "Inserted";
                },
                transactionOptions,
                cancellationToken);

            Console.WriteLine(result);
        }
    }
}