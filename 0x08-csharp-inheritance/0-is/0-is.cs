using System;
using System.Collections.Generic;

/// <summary>Class obj</summary>
class Obj
{
    /// <summary>IsOfTypeInt</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (obj is int)
        {
            return true;
        }
        return false;
    }
}

