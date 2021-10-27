using System;
///<summary> abstract class Base </summary>

public abstract class Base
{
    ///<summary> abstract class Base </summary>
    public string name = "";

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
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; } = 1;
    public bool isCollected { get; set; } = false;
    public void Interact()
    {
    }
    public void Break()
    {
    }
    public void Collect()
    {
    }
}