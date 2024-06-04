public interface ISpellbook
{
    void CastSpell();
}

public class RealSpellbook : ISpellbook
{
    private string spellName;

    public RealSpellbook(string spellName)
    {
        this.spellName = spellName;
        LoadSpell();
    }

    private void LoadSpell()
    {
        Console.WriteLine($"Loading spell: {spellName}");
    }

    public void CastSpell()
    {
        Console.WriteLine($"Casting spell: {spellName}");
    }
}

public class SpellbookProxy : ISpellbook
{
    private RealSpellbook realSpellbook;
    private string spellName;
    private int wizardMana;
    private int spellManaCost;

    public SpellbookProxy(string spellName, int spellManaCost, int wizardMana)
    {
        this.spellName = spellName;
        this.spellManaCost = spellManaCost;
        this.wizardMana = wizardMana;
    }

    public void CastSpell()
    {
        if (wizardMana >= spellManaCost)
        {
            if (realSpellbook == null)
            {
                realSpellbook = new RealSpellbook(spellName);
            }
            realSpellbook.CastSpell();
        }
        else
        {
            Console.WriteLine($"Not enough mana to cast {spellName}. Mana required: {spellManaCost}, Mana available: {wizardMana}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int wizardMana = 50;

        ISpellbook fireballSpell = new SpellbookProxy("Fireball", 30, wizardMana);
        ISpellbook lightningSpell = new SpellbookProxy("Lightning Bolt", 60, wizardMana);

        fireballSpell.CastSpell(); // Should succeed
        lightningSpell.CastSpell(); // Should fail due to insufficient mana
    }
}

