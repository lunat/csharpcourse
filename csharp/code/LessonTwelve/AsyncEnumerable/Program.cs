using static System.Console;

await foreach (int number in GetEnumerableAsync())
{
    WriteLine($"Number {number}");
}


static async IAsyncEnumerable<int> GetEnumerableAsync()
{
    Random r = new();
    
    await Task.Delay(r.Next(1500, 3000));
    yield return r.Next(0, 1001);
    
    await Task.Delay(r.Next(1500, 3000));
    yield return r.Next(0, 1001);

    await Task.Delay(r.Next(1500, 3000));
    yield return r.Next(0, 1001);
}