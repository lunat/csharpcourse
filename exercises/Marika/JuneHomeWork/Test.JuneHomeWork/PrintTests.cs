using Moq;
using Xunit;
using JuneHomeWork;
using JuneHomeWork.Printers;
using System.Collections.Generic;

namespace Test.JuneHomeWork;

public class PrintTests
{
    [Fact]
    public void Print_WillInvokePrintOnce_WhenInkjetAndLaserjetAreInjected()
    {
        Mock<IPrintable> _inkJetMock = new Mock<IPrintable>();
        Mock<IPrintable> _laserJetMock = new Mock<IPrintable>();

        string text = "Text to print";
        Printer _sut = new Printer(new List<IPrintable>
        {
            _inkJetMock.Object,
            _laserJetMock.Object
        });
        _sut.Print(text);

        _laserJetMock.Verify(x => x.Print(text), Times.Once);
    }
}
