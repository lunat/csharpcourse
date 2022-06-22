using static System.Console;
namespace InterfaceExample;

public class Push : IMessage
{
    public string TelephoneNumber { get; set; }

    public void SendMessage()
    {
        WriteLine($"Send push notification to {TelephoneNumber}");
    }
}