using System;

///<summary> Shape </summary>
class Shape
{
    ///<summary> Area </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary> Rectangle </summary>
class Rectangle : Shape
{
    ///<summary> Attributes </summary>
    private int _width;
    private int _height;
    ///<summary> Width </summary>
    public int Width
    {
        ///<summary> get </summary>
        get
        {
            return _width;
        }
        ///<summary> set</summary>
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                _width = value;
            }
        }
    }

    ///<summary> Height </summary>
    public int Height
    {
        ///<summary> get </summary>
        get
        {
            return _height;
        }
        ///<summary> set </summary>
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                _height = value;
            }
        }
    }
}