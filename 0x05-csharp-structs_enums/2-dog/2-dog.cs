using System;

public enum Rating {
  Good,
  Great,
  Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    
    public Poppy(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
