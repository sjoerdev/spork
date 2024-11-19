using System;

namespace Project;

public class Entry
{
    static void Main()
    {
        GameEngine instance = GameEngine.Instance;
        new Game();
        instance.Run();
    }
}

public class Game : GameObject
{
    public override void GameInitialize()
    {
        Engine.title = "spork game engine";
        Engine.windowWidth = 800;
        Engine.windowHeight = 600;
        Engine.scale = new(2, 2);
        Engine.clearColor = new(0, 0, 0);
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