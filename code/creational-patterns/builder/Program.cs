using System;
using System.Collections.Generic;
using System.Text;

public class Skill
{
    public string Name { get; set; }

    public Skill(string name)
    {
        Name = name;
    }
}

public class Adventurer
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Intelligence { get; set; }
    public string Weapon { get; set; }
    public string Armor { get; set; }
    public int Mana { get; set; }
    public int Faith { get; set; }
    public int Luck { get; set; }
    public List<Skill> Skills { get; set; }

    public Adventurer()
    {
        Skills = new List<Skill>();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Class: {Class}");
        sb.AppendLine($"Strength: {Strength}");
        sb.AppendLine($"Agility: {Agility}");
        sb.AppendLine($"Intelligence: {Intelligence}");
        sb.AppendLine($"Weapon: {Weapon}");
        sb.AppendLine($"Armor: {Armor}");
        sb.AppendLine($"Mana: {Mana}");
        sb.AppendLine($"Faith: {Faith}");
        sb.AppendLine($"Luck: {Luck}");
        sb.AppendLine($"Skills:");
        foreach (var skill in Skills)
        {
            sb.AppendLine($"- {skill.Name}");
        }
        return sb.ToString();
    }
}

public interface IAdventurerBuilder
{
    IAdventurerBuilder SetName(string name);
    IAdventurerBuilder SetClass(string className);
    IAdventurerBuilder SetStrength(int strength);
    IAdventurerBuilder SetAgility(int agility);
    IAdventurerBuilder SetIntelligence(int intelligence);
    IAdventurerBuilder SetWeapon(string weapon);
    IAdventurerBuilder SetArmor(string armor);
    IAdventurerBuilder AddSkill(Skill skill);
    IAdventurerBuilder SetMana(int mana);
    IAdventurerBuilder SetFaith(int faith);
    IAdventurerBuilder SetLuck(int luck);
    Adventurer Build();
}

public class AdventurerBuilder : IAdventurerBuilder
{
    private Adventurer _adventurer;

    public AdventurerBuilder()
    {
        _adventurer = new Adventurer();
    }

    public IAdventurerBuilder SetName(string name)
    {
        _adventurer.Name = name;
        return this;
    }

    public IAdventurerBuilder SetClass(string className)
    {
        _adventurer.Class = className;
        return this;
    }

    public IAdventurerBuilder SetStrength(int strength)
    {
        _adventurer.Strength = strength;
        return this;
    }

    public IAdventurerBuilder SetAgility(int agility)
    {
        _adventurer.Agility = agility;
        return this;
    }

    public IAdventurerBuilder SetIntelligence(int intelligence)
    {
        _adventurer.Intelligence = intelligence;
        return this;
    }

    public IAdventurerBuilder SetWeapon(string weapon)
    {
        _adventurer.Weapon = weapon;
        return this;
    }

    public IAdventurerBuilder SetArmor(string armor)
    {
        _adventurer.Armor = armor;
        return this;
    }

    public IAdventurerBuilder AddSkill(Skill skill)
    {
        _adventurer.Skills.Add(skill);
        return this;
    }

    public IAdventurerBuilder SetMana(int mana)
    {
        _adventurer.Mana = mana;
        return this;
    }

    public IAdventurerBuilder SetFaith(int faith)
    {
        _adventurer.Faith = faith;
        return this;
    }

    public IAdventurerBuilder SetLuck(int luck)
    {
        _adventurer.Luck = luck;
        return this;
    }

    public Adventurer Build()
    {
        return _adventurer;
    }
}

public class AdventurerDirector
{
    private IAdventurerBuilder _builder;

    public AdventurerDirector(IAdventurerBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructAdventurer(string name, List<Skill> skills)
    {
        _builder
            .SetName(name)
            .SetClass("Adventurer")
            .SetStrength(10)
            .SetAgility(10)
            .SetIntelligence(10)
            .SetWeapon("Sword")
            .SetArmor("Leather Armor");

        foreach (var skill in skills)
        {
            _builder.AddSkill(skill);
        }
    }
}

public class PaladinDirector
{
    private IAdventurerBuilder _builder;

    public PaladinDirector(IAdventurerBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructPaladin(string name, List<Skill> skills)
    {
        _builder
            .SetName(name)
            .SetClass("Paladin")
            .SetStrength(15)
            .SetAgility(8)
            .SetIntelligence(10)
            .SetWeapon("Sword and Shield")
            .SetArmor("Plate Armor")
            .SetFaith(15);

        foreach (var skill in skills)
        {
            _builder.AddSkill(skill);
        }
    }
}

public class ClericDirector
{
    private IAdventurerBuilder _builder;

    public ClericDirector(IAdventurerBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructCleric(string name, List<Skill> skills)
    {
        _builder
            .SetName(name)
            .SetClass("Cleric")
            .SetStrength(8)
            .SetAgility(10)
            .SetIntelligence(12)
            .SetWeapon("Mace")
            .SetArmor("Chainmail")
            .SetMana(20)
            .SetFaith(18);

        foreach (var skill in skills)
        {
            _builder.AddSkill(skill);
        }
    }
}

public class SorcererDirector
{
    private IAdventurerBuilder _builder;

    public SorcererDirector(IAdventurerBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructSorcerer(string name, List<Skill> skills)
    {
        _builder
            .SetName(name)
            .SetClass("Sorcerer")
            .SetStrength(6)
            .SetAgility(10)
            .SetIntelligence(20)
            .SetWeapon("Staff")
            .SetArmor("Robe")
            .SetMana(30);

        foreach (var skill in skills)
        {
            _builder.AddSkill(skill);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create builder instance
        IAdventurerBuilder adventurerBuilder = new AdventurerBuilder();

        // Create Directors
        AdventurerDirector adventurerDirector = new AdventurerDirector(adventurerBuilder);
        PaladinDirector paladinDirector = new PaladinDirector(adventurerBuilder);
        ClericDirector clericDirector = new ClericDirector(adventurerBuilder);
        SorcererDirector sorcererDirector = new SorcererDirector(adventurerBuilder);

        // Construct Adventurer
        adventurerDirector.ConstructAdventurer("Kazuma", new List<Skill> { new Skill("Steal"), new Skill("Detect Lie") });
        Adventurer kazuma = adventurerBuilder.Build();
        Console.WriteLine("Kazuma:");
        Console.WriteLine(kazuma.ToString());

        // Construct Paladin
        paladinDirector.ConstructPaladin("Darkness", new List<Skill> { new Skill("Holy Strike"), new Skill("Divine Shield") });
        Adventurer darkness = adventurerBuilder.Build();
        Console.WriteLine("Darkness:");
        Console.WriteLine(darkness.ToString());

        // Construct Cleric
        clericDirector.ConstructCleric("Aqua", new List<Skill> { new Skill("Heal"), new Skill("Bless") });
        Adventurer aqua = adventurerBuilder.Build();
        Console.WriteLine("Aqua:");
        Console.WriteLine(aqua.ToString());

        // Construct Sorcerer
        sorcererDirector.ConstructSorcerer("Megumin", new List<Skill> { new Skill("Fireball"), new Skill("Teleport") });
        Adventurer megumin = adventurerBuilder.Build();
        Console.WriteLine("Megumin:");
        Console.WriteLine(megumin.ToString());
    }
}
