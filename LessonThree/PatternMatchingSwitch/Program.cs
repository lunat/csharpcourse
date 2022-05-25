using static System.Console;

string path = @"C:\Users\Luca\projects";
Write("Press R for ReadOnly or W for writeable:");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt")
        , FileMode.OpenOrCreate
        , FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt")
        , FileMode.OpenOrCreate
        , FileAccess.Write);
}

string message;

//switch (s)
//{
//    case FileStream writeableFile when s.CanWrite:
//        message = "The stream is a file that I can write to";
//        break;
//    case FileStream readOnlyFile:
//        message = "The stream is a read-only file";
//        break;
//    case MemoryStream ms:
//        message = "The stream is a memory address";
//        break;
//    case null:
//        message = "The stream is null";
//        break;
//    default:
//        message = "The stream is something else";
//        break;
//}
message = s switch
{
    FileStream writeableFile when s.CanWrite
        => "The stream is a file that I can write to",
    FileStream readOnlyFile
        => "The stream is a read-only file",
    MemoryStream ms
        => "The stream is a memory address",
    null
        => "The stream is null",
    _
        => "The stream is something else"
};
WriteLine(message);
