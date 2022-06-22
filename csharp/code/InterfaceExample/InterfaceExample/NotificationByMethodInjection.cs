namespace InterfaceExample;
internal class NotificationByMethodInjection
{
    //private ICollection<IMessage> _messages;

    public void Send(ICollection<IMessage> messages)
    {
        //_messages = messages;

        foreach (var message in messages)
        {
            message.SendMessage();
        }
    }
}

