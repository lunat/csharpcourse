using static System.Console;

WriteLine("I can run everywhere!");
WriteLine($"OS Version is {Environment.OSVersion}");
if (OperatingSystem.IsMacOS())
{
    WriteLine("I am MAC.");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    WriteLine("I am Windows 10 or 11");
}
else
{
    WriteLine("I am something else...");
}

WriteLine("Press ENTER to quit");
ReadLine();