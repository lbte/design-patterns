using System;

public class Portal
{
    private static Portal instance;

    // Private constructor to prevent external instantiation
    private Portal() 
    {
        Console.WriteLine("Portal instance created!");
    }

    // Static method to provide access to the single instance
    public static Portal GetInstance()
    {
        // Lazy initialization: create the instance only when it's first requested
        if (instance == null)
        {
            instance = new Portal();
        }
        return instance;
    }

    public void OpenPortal()
    {
        Console.WriteLine("Portal opened!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Accessing the Singleton instance
        Portal portal1 = Portal.GetInstance();
        Portal portal2 = Portal.GetInstance();

        // Both portal1 and portal2 should refer to the same instance
        Console.WriteLine($"Is portal1 the same instance as portal2? {portal1 == portal2}");

        // Using the Singleton instance to open a portal
        portal1.OpenPortal();
    }
}
