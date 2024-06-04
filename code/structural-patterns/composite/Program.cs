using System.Collections.Generic;

public interface IGameElement
{
    void Render();
    void Move(int x, int y);
}

public class Tree : IGameElement
{
    private string name;

    public Tree(string name)
    {
        this.name = name;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering Tree: {name}");
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving Tree {name} to ({x}, {y})");
    }
}

public class Enemy : IGameElement
{
    private string name;

    public Enemy(string name)
    {
        this.name = name;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering Enemy: {name}");
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving Enemy {name} to ({x}, {y})");
    }
}


public class Fortress : IGameElement
{
    private string name;
    private List<IGameElement> children = new List<IGameElement>();

    public Fortress(string name)
    {
        this.name = name;
    }

    public void Add(IGameElement element)
    {
        children.Add(element);
    }

    public void Remove(IGameElement element)
    {
        children.Remove(element);
    }

    public void Render()
    {
        Console.WriteLine($"Rendering Fortress: {name}");
        foreach (var child in children)
        {
            child.Render();
        }
    }

    public void Move(int x, int y)
    {
        Console.WriteLine($"Moving Fortress {name} to ({x}, {y})");
        foreach (var child in children)
        {
            child.Move(x, y);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create simple elements
        IGameElement tree1 = new Tree("Tree 1");
        IGameElement enemy1 = new Enemy("Enemy 1");

        // Create a complex element and add simple elements to it
        Fortress fortress1 = new Fortress("Fortress 1");
        fortress1.Add(tree1);
        fortress1.Add(enemy1);

        // Create another simple element
        IGameElement tree2 = new Tree("Tree 2");

        // Create a top-level composite and add both simple and complex elements
        Fortress gameLevel = new Fortress("Game Level");
        gameLevel.Add(fortress1);
        gameLevel.Add(tree2);

        // Render and move all elements in the game level
        gameLevel.Render();
        gameLevel.Move(10, 20);
    }
}
