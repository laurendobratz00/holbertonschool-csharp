using System;
///<summary> abstract class Base </summary>

public abstract class Base
{
    ///<summary> abstract class Base </summary>
    public string name = "";

    public override string ToString()
    {
        ///<summary> override tostring method </summary>
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
///<summary> class TestObject </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary> durability </summary>
    public int durability { get; set; } = 1;
    ///<summary> isCollected </summary>
    public bool isCollected { get; set; } = false;
    ///<summary> Interact method </summary>
    public void Interact()
    {
    }
    ///<summary> Break method </summary>
    public void Break()
    {
    }
    ///<summary> Collect method </summary>
    public void Collect()
    {
    }
}