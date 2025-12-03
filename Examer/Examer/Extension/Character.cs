namespace Examer.Extension;

public abstract class Character
{
    private readonly string _characterType;

    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

public class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
        {
            return 10;
        }
        else
        {
            return 6;
        }
    }
}

public class Wizard : Character
{
    public bool IsSpellPrepared { get; set; } = false;

    public Wizard() : base("Wizard")
    {
    }

    public override bool Vulnerable()
    {
        return !IsSpellPrepared;
    }

    public override int DamagePoints(Character target)
    {
        if (IsSpellPrepared)
        {
            return 12;
        }
        else
        {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        IsSpellPrepared = true;
    }
}
