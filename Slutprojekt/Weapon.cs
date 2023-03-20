using System;

public class weapon     //vapen klassen med alla dess variablar
{
    public string name = "lightsaber";
    private Random generator = new();      
    
    public int GetDamage()      //funktion för random generator som genererar ett tal mellan 8 och 20
    {
        return generator.Next(8, 20);
    }
}
