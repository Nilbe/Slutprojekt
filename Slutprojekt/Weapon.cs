using System;

public class weapon     //vapen klassen med alla dess variablar
{
    public string name = "lightsaber";
    public int maxDamage = 20;
    public int minDamage = 8;
    private Random generator = new();       //random generator som genererar ett tal mellan 8 och 20
    
    public int GetDamage()      //funktion för random generator som genererar ett tal mellan 8 och 20
    {
        return generator.Next(minDamage, maxDamage);
    }
}
