using System;
public interface IGameController
{
    void SendKey(char key);
}

public class XboxAdapter : IGameController
{
    private readonly XboxController _adaptee;
    public XboxAdapter(XboxController adaptee)
    {
        this._adaptee = adaptee;
    }
    public void SendKey(char key)
    {
        string button = "";
        switch (key)
        {
            case 'w':
                button = "UP";
                break;
            case 's':
                button = "DOWN";
                break;
            case 'a':
                button = "LEFT";
                break;
            case 'd':
                button = "RIGHT";
                break;

        }
        _adaptee.PressButton(button);
    }
}

public class XboxController
{
    public void PressButton(string button)
    {
        Console.WriteLine(button);
    }
}

public class Game
{
    private readonly IGameController _gameController;

    public Game(IGameController gameController)
    {
        _gameController = gameController;
    }
    public void Play()
    {
        _gameController.SendKey('a');
        _gameController.SendKey('w');
    }
}

class Program
{
    public static void Main()
    {
        XboxController xbox = new XboxController();
        IGameController gameController = new XboxAdapter(xbox);

        Game game = new Game(gameController);
        game.Play();
    }
}
