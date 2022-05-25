object obj = "3";
int j = 4;

if (obj is int i)
{
    Console.WriteLine($"{i} x {j} = { i*j}");
}
else
{
    Console.WriteLine($"obj is not an int");
}