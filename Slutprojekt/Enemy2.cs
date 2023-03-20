using System;

public class Enemy2: Characters
{
    string name { get;set; }
    
    public Enemy2()
    {
        color = Color.RED;
        rect = new Rectangle(500,300,32,32);
        HP = 100;
    }
}
