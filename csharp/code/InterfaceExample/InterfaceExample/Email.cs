using static System.Console;
namespace InterfaceExample;

public class Email : IMessage
{
    public string To { get; set; }
    public string From { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

    public void SendMessage()
    {
        WriteLine($"Mail sent to {To} from {From}");
    }
}