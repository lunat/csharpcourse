using static System.Console;
namespace InterfaceExample;

public class Sms : IMessage
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }

    public void SendMessage()
    {
        WriteLine($"SMS Message: {Message}");
    }
}