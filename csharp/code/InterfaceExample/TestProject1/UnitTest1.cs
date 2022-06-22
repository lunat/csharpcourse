using System.Collections.Generic;
using InterfaceExample;
using Moq;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Send_WillInkokeMailAndSmsOnce_WhenMailAndSmsAreInjectedInConstructor()
    {
        Mock<IMessage> _mailMock = new Mock<IMessage>();
        Mock<IMessage> _smsMock = new Mock<IMessage>();

        Notification _sut =
            new Notification(new List<IMessage>
            {
                _mailMock.Object,
                _smsMock.Object
            });

        _sut.Send();

        _mailMock.Verify(x => x.SendMessage(), Times.Once);
        _smsMock.Verify(x => x.SendMessage(), Times.Once);
    }

    [Fact]
    public void Send_WillNotInkokePush_WhenPushIsNotInjectedInConstructor()
    {
        Mock<IMessage> _mailMock = new Mock<IMessage>();
        Mock<IMessage> _smsMock = new Mock<IMessage>();
        Mock<IMessage> _pushMock = new Mock<IMessage>();

        Notification _sut =
            new Notification(new List<IMessage>
            {
                _mailMock.Object,
                _smsMock.Object
            });

        _sut.Send();

        _pushMock.Verify(x => x.SendMessage(), Times.Never);
    }
}
