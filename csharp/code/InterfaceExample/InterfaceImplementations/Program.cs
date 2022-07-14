var person = new Person();
// calls implicit implementation
person.Lose();
// calls explicit implementation
((IGamePlayer)person).Lose();
IGamePlayer player = person as IGamePlayer;
// calls explicit implementation
player.Lose();

public interface IGamePlayer
{
    void Lose();
}

public interface IKeyHolder
{
    void Lose();
}

public class Person : IGamePlayer, IKeyHolder
{
    public void Lose()
    {

    }

    void IGamePlayer.Lose()
    {

    }
}
