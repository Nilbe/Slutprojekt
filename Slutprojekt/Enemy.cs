using System;

public class Enemy: Characters      //all information unik för enemy
{
    string name { get;set; }

    public Enemy()
    {
        color = Color.RED;
        rect = new Rectangle(500,300,32,32);
    }
}