using System;

///<summary> class Player </summary>
public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    /// <summary> status </summary>
    private string status { get; set; }

    /// <summary> HPCheck </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    ///<summary> Player constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp < 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
        this.status = this.name + " is ready to go!";
        HPCheck += CheckStatus;
    }

    ///<summary> Prints the player's health status </summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    /// <summary> CalculateHealth delegate </summary>
    delegate void CalculateHealth(float health);

    /// <summary> TakeDamage method </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine(this.name + " takes 0 damage!");
        }
        else
        {
            Console.WriteLine(this.name + " takes " + damage + " damage!");
        }
        this.hp -= damage;
        ValidateHP(this.hp);
    }

    /// <summary> HealDamage method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
            Console.WriteLine(this.name + " heals 0 HP!");
        }
        else
        {
            Console.WriteLine(this.name + " heals " + heal + " HP!");
        }
        this.hp += heal;
        ValidateHP(this.hp);
    }
    /// <summary> ValidateHP method </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }
        else if (newHp > maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }
    /// <summary> ApplyModifier method </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return (baseValue / 2f);
        }
        else if (modifier == Modifier.Strong)
        {
            return (baseValue * 1.5f);
        }
        else
        {
            return (baseValue);
        }
    }

    /// <summary> CheckStatus method </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp)
        {
            status = this.name + " is in perfect health!";
        }
        else if (e.currentHP >= (maxHp / 2))
        {
            status = this.name + " is doing well!";
        }
        else if (e.currentHP >= (maxHp / 4))
        {
            status = this.name + " isn't doing too great...";
        }
        else if (e.currentHP > 0)
        {
            status = this.name + " needs help!";
        }
        else
        {
            status = this.name + " is knocked out!";
        }
        Console.WriteLine(this.status);
    }
    /// <summary> HPValueWarning method </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }
    /// <summary> OnCheckStatus method </summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHP < (maxHp / 4))
        {
            HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
    }
}
/// <summary> enum Modifier </summary>
public enum Modifier
{
    /// <summary> Weak </summary>
    Weak,
    /// <summary> Base </summary>
    Base,
    /// <summary> Strong </summary>
    Strong
}
/// <summary> CalculateModifier delegate </summary>
delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> class CurrentHPArgs </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> currentHP </summary>
    public readonly float currentHP;
    
    /// <summary> constructor CurrentHPArgs </summary>
    public CurrentHPArgs(float newHP)
    {
        this.currentHP = newHP;
    }
}