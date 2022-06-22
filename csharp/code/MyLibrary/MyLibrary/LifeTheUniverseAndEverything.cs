namespace MyLibrary;

public class TextAndNumber
{
    public string Text;
    public int Number;
}

public class LifeTheUniverseAndEverything
{
    public (string Message, int Code) GetTheDataAsTuple()
    {
        return (Message: "What's the meaning of life?", Code: 42);
    }
    public TextAndNumber GetTheData()
    {
        return new TextAndNumber
        {
            Text = "What's the meaning of life?",
            Number = 42
        };
    }
}