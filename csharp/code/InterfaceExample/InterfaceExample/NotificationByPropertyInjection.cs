namespace InterfaceExample;

public class NotificationByPropertyInjection
{
    private ICollection<IMessage> _messages;

    public ICollection<IMessage> SetMessages
    {
        set => _messages = value;
    }

    public void Send()
    {
        foreach (var message in _messages)
        {
            message.SendMessage();
        }
    }
}