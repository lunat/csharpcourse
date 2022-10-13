using static System.Console;

//ExecuteSync();

await ExecuteAsync();

async Task ExecuteAsync()
{
    var path =
        Path.Combine(Environment.CurrentDirectory, "MyTextFile.txt");

    var lines = GetLinesAsync(path);

    await foreach (string line in lines)
    {
        WriteLine(line);
    }
}

void ExecuteSync()
{
    var path = 
        Path.Combine(Environment.CurrentDirectory, "MyTextFile.txt");

    foreach (string line in GetLines(path))
    {
        WriteLine(line);
    }
}

IEnumerable<string> GetLines(string path)
{
    List<string> lines = new List<string>();
    string line;

    StreamReader file = new StreamReader(path);
    while ((line = file.ReadLine()) is not null)
    {
        Thread.Sleep(1000);
        lines.Add(line);
    }
    return lines;
}

async IAsyncEnumerable<string> GetLinesAsync(string path)
{
    string line;
    StreamReader file = new StreamReader(path);

    while ((line = await file.ReadLineAsync()) is not null)
    {
        await Task.Delay(1000);
        yield return line;
    }
}