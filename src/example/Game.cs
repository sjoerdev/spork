using Spork;

namespace Game;

public class Entry
{
    static void Main()
    {
        Engine instance = Engine.Instance;
        new Game();
        instance.Run();
    }
}

public class Game : GameObject
{
    public override void GameInitialize()
    {
        engine.title = "spork game engine";
        engine.windowWidth = 800;
        engine.windowHeight = 600;
        engine.scale = new(2, 2);
        engine.clearColor = new(0, 0, 0);
    }

    public override void GameStart()
    {
        // runs at the start of the game
    }

    public override void Update()
    {
        // game logic here, runs each frame
    }

    public override void Paint()
    {
        // rendering logic here, runs each frame
    }

    public override void GameEnd()
    {
        // runs when you quit the game
    }
}