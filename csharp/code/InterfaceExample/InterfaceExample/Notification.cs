namespace InterfaceExample;

public class Notification
{
    private ICollection<IMessage> _messages;

    //private Email _email;
    //private Sms _sms;
    //private Push _push;

    public Notification(ICollection<IMessage> messages)
    {
        //_email = new Email();
        //_sms = new Sms();
        //_push = new Push();
        _messages = messages;
    }

    public void Send()
    {
        foreach (var message in _messages)
        {
            message.SendMessage();
        }
        //_email.SendMessage();
        //_sms.SendMessage();
        //_push.SendMessage();
    }
}