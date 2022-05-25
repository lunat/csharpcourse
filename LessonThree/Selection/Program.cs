string password = "pippo";

if (CheckPasswordLength(password))
{
    Console.WriteLine("KO scrivi una password lunga...!!!");
}
else
{
    Console.WriteLine("OK");
}

static bool CheckPasswordLength(string password)
{
    return password.Length < 10;

}