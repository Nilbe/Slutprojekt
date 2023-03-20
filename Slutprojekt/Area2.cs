using System;

public class Area2
{
    private Player player;
    private Enemy2 enemy;
    public int end = 1;
    private bool hasAttacked = false;
    private Vector2 textPos = new Vector2(150, 200);
    private Vector2 textPos2 = new Vector2(200, 250);
    private Vector2 textPosPHP = new Vector2(50, 20);
    private Vector2 textPosEHP = new Vector2(500, 20);
    private Vector2 textPosTEMP = new Vector2(500, 20);

    public Area2()
    {
        player = new Player();
        enemy = new Enemy2();

        player.weapon = new weapon();
        enemy.weapon = new weapon();
    }

    public void Update()    //logik för spelet
    {
        player.Update();
        enemy.Update();

        if (Raylib.CheckCollisionRecs(player.rect, enemy.rect))     //om spelaren kolliderar med fienden så gör dem skada på varandra en gång
        {
            if (hasAttacked)
            {
                return;     //om hasAttacked har utförts så ruturnerar den boolen till false
            }
            player.Attack(enemy);
            enemy.Attack(player);

            hasAttacked = true;
        }
        else
        {
            hasAttacked = false;    
        }

        if(player.HP == 0 && enemy.HP == 0)     //kollar om någon av karaktärerna har 0 hälsa kvar och säger då hur spelet ska sluta
        {
            end = 2;
        }
        else if(player.HP == 0) 
        {
            end = 3;
        }
        else if(enemy.HP == 0)
        {
            end = 4;
        }
    }

    public void Draw()      //utritandet av karaktärerna och texten
    {
        if(end == 1)        //end 1 är spelet
        {
            player.Draw();
            enemy.Draw();

            Raylib.DrawTextEx(default, "Player HP:", textPosPHP, 20, 10, Color.BLACK);
            Raylib.DrawText(player.HP.ToString(), 250, 20, 25, Color.BLACK);
            Raylib.DrawTextEx(default, "Enemy HP:", textPosEHP, 20, 10, Color.BLACK);
            Raylib.DrawText(enemy.HP.ToString(), 700, 20, 25, Color.BLACK);
        }
        if(end == 2)        //de olika sluten till spelet
        {
            Raylib.DrawTextEx(default, "TIE", textPos, 20, 10, Color.BLACK);
            
        }
        if(end == 3)
        {
            Raylib.DrawTextEx(default, "You Lose", textPos, 20, 10, Color.BLACK);
        }
        if(end == 4)
        {
            player.Draw();

            Raylib.DrawTextEx(default, "Player HP:", textPosPHP, 20, 10, Color.BLACK);
            Raylib.DrawText(player.HP.ToString(), 250, 20, 25, Color.BLACK);

            Raylib.DrawTextEx(default, "You Won and Got a Health Potion", textPos, 20, 10, Color.BLACK);
            Raylib.DrawTextEx(default, "To Continue Go Right", textPos2, 20, 10, Color.BLACK);
        }
    }
}