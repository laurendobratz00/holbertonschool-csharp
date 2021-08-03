using System;

/// <summary>Class obj</summary>
class Obj
{
    /// <summary>IsInstanceOfArray</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}

