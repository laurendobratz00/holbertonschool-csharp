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
