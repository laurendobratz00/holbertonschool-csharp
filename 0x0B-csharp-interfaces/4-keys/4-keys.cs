using System;

///<summary> abstract class Base </summary>
public abstract class Base
{
    ///<summary> name </summary>
    public string name { get; set; }

    ///<summary> override tostring method </summary>
    public override string ToString()
    {
        Type tp = name.GetType();
        return (name + " is a " + this.GetType());
    }
}

interface IInteractive
{
    void Interact();
}
interface IBreakable
{
    int durability
    {
        get;
        set;
    }
    void Break();
}
interface ICollectable
{
    bool isCollected
    {
        get;
        set;
    }
    void Collect();
}
///<summary> class Door </summary>
public class Door : Base, IInteractive
{
    ///<summary> Door constructor </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    ///<summary> Interact method </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}

///<summary> class Decoration </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary> isQuestItem </summary>
    public bool isQuestItem;
    ///<summary> durability prop </summary>
    public int durability { get; set; }
    ///<summary> constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    ///<summary> Interact method </summary>
    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", this.name);
        }
        else
        {
            if (isQuestItem)
                Console.WriteLine("You look at the " + this.name + ". There's a key inside.");
            else
                Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
        }
    }
    ///<summary> Break method </summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
        {
            Console.WriteLine("You hit the " + this.name + ". It cracks.");
        }
        if (this.durability == 0)
        {
            Console.WriteLine("You smash the " + this.name + ". What a mess.");
        }
        if (this.durability < 0)
        {
            Console.WriteLine("The " + this.name + " is already broken.");
        }
    }
}
///<summary> class Key </summary>
public class Key : Base, ICollectable
{
    ///<summary> isCollected</summary>
    public bool isCollected { get; set; }

    ///<summary> constructor </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    ///<summary> Collect method </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the " + this.name + ".");
        }
        else
        {
            Console.WriteLine("You have already picked up the " + this.name + ".");
        }
    }
}