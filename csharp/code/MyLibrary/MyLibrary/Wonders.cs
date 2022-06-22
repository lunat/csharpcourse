namespace MyLibrary;

[Flags]
public enum Wonders : byte
{
    None = 0,
    GreatPyramidOfGiza = 1,
    HangingGardens = 2,
    StatueOfZeusAtOlympia = 4,
    TempleOfArtemisAtEphesus = 8,
    MausoleumAtHalicarnassus = 16,
    ColossusOfRhodes = 32,
    LighthouseOfAlexandria = 64
}
