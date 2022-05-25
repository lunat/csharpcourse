using static System.Console;

byte[] binaryObject = new byte[128];

(new Random()).NextBytes(binaryObject);

WriteLine("Binary object as bytes:");
for (int i = 0; i < binaryObject.Length; i++)
{
    Write($"{binaryObject[i]:X}");
}
WriteLine();

string encoded = Convert.ToBase64String(binaryObject);
Console.WriteLine($"Binary Object to Base64 {encoded}");