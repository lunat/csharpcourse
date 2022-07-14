namespace DefaultInterfaceImplementation;

public class DvdPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("DVD Player is playing");
    }

    public void Pause()
    {
        Console.WriteLine("DVD Player is pausing");
    }
}