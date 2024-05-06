using System;

// Abstract Product Interfaces
public interface Soldier
{
    void Fight();
}

public interface Vehicle
{
    void Move();
}

public interface Structure
{
    void Build();
}

// Concrete Product Implementations
public class RobotSoldier : Soldier
{
    public void Fight()
    {
        Console.WriteLine("Robot Soldier fights with precision and strength.");
    }
}

public class ElfArcher : Soldier
{
    public void Fight()
    {
        Console.WriteLine("Elf Archer attacks swiftly with deadly accuracy.");
    }
}

public class HoverTank : Vehicle
{
    public void Move()
    {
        Console.WriteLine("Hover Tank glides gracefully across the battlefield.");
    }
}

public class Treant : Vehicle
{
    public void Move()
    {
        Console.WriteLine("Treant moves with the strength of nature, crushing obstacles in its path.");
    }
}

public class TechLab : Structure
{
    public void Build()
    {
        Console.WriteLine("Tech Lab constructs advanced machinery and weaponry.");
    }
}

public class Grove : Structure
{
    public void Build()
    {
        Console.WriteLine("Grove nurtures life, fostering harmony with nature.");
    }
}

// Abstract Factory
public interface ICivilizationFactory
{
    Soldier CreateSoldier();
    Vehicle CreateVehicle();
    Structure CreateStructure();
}

// Concrete Factory for Technocrats
public class TechnocratFactory : ICivilizationFactory
{
    public Soldier CreateSoldier() => new RobotSoldier();
    public Vehicle CreateVehicle() => new HoverTank();
    public Structure CreateStructure() => new TechLab();
}

// Concrete Factory for Druids
public class DruidFactory : ICivilizationFactory
{
    public Soldier CreateSoldier() => new ElfArcher();
    public Vehicle CreateVehicle() => new Treant();
    public Structure CreateStructure() => new Grove();
}

class Program
{
    static void Main(string[] args)
    {
        // Choose the civilization
        ICivilizationFactory factory = new TechnocratFactory(); // Or new DruidFactory();

        // Create objects using the factory
        Soldier soldier = factory.CreateSoldier();
        Vehicle vehicle = factory.CreateVehicle();
        Structure structure = factory.CreateStructure();

        // Test the objects
        Console.WriteLine("Testing objects created by the factory:");
        Console.WriteLine("---------------------------------------");
        soldier.Fight();
        vehicle.Move();
        structure.Build();
    }
}