using static System.Console;
using System.Net;
using System.Net.NetworkInformation;

Write("Enter a web address:");
string? url = ReadLine();

if (string.IsNullOrWhiteSpace(url))
    url = "https://www.google.com";

Uri uri = new(url);
WriteLine($"URL: {url}");
WriteLine($"Scheme: {uri.Scheme}");
WriteLine($"Port: {uri.Port}");
WriteLine($"Host: {uri.Host}");
WriteLine($"AbsolutePath: {uri.AbsolutePath}");
WriteLine($"Query: {uri.Query}");

IPHostEntry entry = Dns.GetHostEntry(uri.Host);
WriteLine($"{entry.HostName} has the IP Addresses:");
foreach (IPAddress address in entry.AddressList)
{
    WriteLine($"    {address} ({address.AddressFamily})");
}

try
{
    Ping ping = new Ping();
    WriteLine("Pinging server, please wait...");
    PingReply reply = ping.Send(uri.Host);
    WriteLine($"{uri.Host} was pinged and replied {reply.Status}");
    if (reply.Status == IPStatus.Success)
    {
        WriteLine($"reply from {reply.Address} took " +
                  $"{reply.RoundtripTime} ms");
    }
}
catch (Exception e)
{
    WriteLine(e);
    throw;
}

