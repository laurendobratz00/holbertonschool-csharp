﻿using System;
///<summary> abstract class Base </summary>

abstract class Base
{
    ///<summary> abstract class Base </summary>
    public string name { get; set; }

    public override string ToString()
    {
        Type tp = name.GetType();
        return (this.name + " is a " + this.GetType());
    }
}