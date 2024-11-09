using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public interface INPCFlyweight
{
    void Render(NPCExtrinsicState extrinsicState);
}

public class NPCFlyweight : INPCFlyweight
{
    private string Type;
    private string Appearance;
    private string BaseAbilities;
    private string Animations;

    public NPCFlyweight(string type, string appearance, string baseAbilities, string animations)
    {
        Type = type;
        Appearance = appearance;
        BaseAbilities = baseAbilities;
        Animations = animations;
    }

    public void Render(NPCExtrinsicState extrinsicState)
    {
        Console.WriteLine($"NPC Type: {Type}");
        Console.WriteLine($"Position: {extrinsicState.Position}");
        Console.WriteLine($"Health: {extrinsicState.CurrentHealth}");
        Console.WriteLine($"Action: {extrinsicState.CurrentAction}");
        Console.WriteLine($"Appearance: {Appearance}");
        Console.WriteLine($"Abilities: {BaseAbilities}");
        Console.WriteLine($"Animations: {Animations}");
        Console.WriteLine("-----------");
    }
}

public class NPCFlyweightFactory
{
    private Dictionary<string, NPCFlyweight> flyweights = new Dictionary<string, NPCFlyweight>();

    public NPCFlyweight GetFlyweight(string type, string appearance, string baseAbilities, string animations)
    {
        string key = type + appearance;
        if (!flyweights.ContainsKey(key))
        {
            flyweights[key] = new NPCFlyweight(type, appearance, baseAbilities, animations);
        }
        return flyweights[key];
    }
}

public class NPCExtrinsicState
{
    public string Position { get; set; }
    public int CurrentHealth { get; set; }
    public string CurrentAction { get; set; }
}

public class NPC
{
    public string Type { get; private set; }
    public string Appearance { get; private set; }
    public string BaseAbilities { get; private set; }
    public string Animations { get; private set; }
    public string Position { get; set; }
    public int CurrentHealth { get; set; }
    public string CurrentAction { get; set; }

    public NPC(string type, string appearance, string baseAbilities, string animations)
    {
        Type = type;
        Appearance = appearance;
        BaseAbilities = baseAbilities;
        Animations = animations;
    }

    public void Render()
    {
        // Render NPC based on its attributes
        Console.WriteLine($"Rendering {Type} NPC: {Appearance} - Animations: {Animations}");
        Console.WriteLine($"Position: {Position}, Health: {CurrentHealth}, Action: {CurrentAction}");
        Console.WriteLine();
    }
}

[MemoryDiagnoser]
public class Benchmark
{
    private NPCFlyweightFactory flyweightFactory = new NPCFlyweightFactory();
    private List<NPC> npcs = new List<NPC>
    {
        new NPC("Goblin", "Green Goblin", "Slash Attack", "Idle, Attack, Run"),
        new NPC("Villager", "Peasant", "None", "Idle, Talk, Walk"),
        new NPC("Shopkeeper", "Merchant", "Trade", "Idle, Talk, Walk"),
        new NPC("Goblin", "Green Goblin", "Slash Attack", "Idle, Attack, Run")
    };

    [Benchmark]
    public void FlyweightApproach()
    {
        foreach (var npc in npcs)
        {
            INPCFlyweight npcFlyweight = flyweightFactory.GetFlyweight(npc.Type, npc.Appearance, npc.BaseAbilities, npc.Animations);
            npcFlyweight.Render(new NPCExtrinsicState { Position = npc.Position, CurrentHealth = npc.CurrentHealth, CurrentAction = npc.CurrentAction });
        }
    }

    [Benchmark]
    public void NoFlyweightApproach()
    {
        foreach (var npc in npcs)
        {
            npc.Render();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Benchmark>();
    }
}
