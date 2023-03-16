using System;

public class Characters     //all gemensam information för player och enemy
{
    protected Color color;

    public Characters()
    {
        rect = new Rectangle(0,0,32,32);
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, color);
    }

    public virtual void Update() 
    {
        
    }

    public weapon weapon;
    public int HP = 100;
    public Rectangle rect;

    public void Attack(Characters target)       //funktion för att kunna attackera
    {
        int damage = weapon.GetDamage();
        target.HP -= damage; 
        target.HP = Math.Max(0, target.HP);
    }
}
