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
}
