using System;

///<summary> class Player </summary>
public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

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
    }
}
