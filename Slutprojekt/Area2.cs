using System;

public class Area2: Area
{
    private Enemy2 enemy;
    private Vector2 textPos = new Vector2(150, 200);
    private Vector2 textPos2 = new Vector2(200, 250);
    private Vector2 textPosPHP = new Vector2(50, 20);
    private Vector2 textPosEHP = new Vector2(500, 20);

    public Area2()
    {
        enemy = new Enemy2();

        player.rect.x = 0;
    }

    public override void Draw()      //utritandet av karaktärerna och texten
    {
        if(gameStage == 1)        //gameStage 1 är spelet
        {
            player.Draw();
            enemy.Draw();

            Raylib.DrawTextEx(default, "Player HP:", textPosPHP, 20, 10, Color.BLACK);
            Raylib.DrawText(player.HP.ToString(), 250, 20, 25, Color.BLACK);
            Raylib.DrawTextEx(default, "Enemy HP:", textPosEHP, 20, 10, Color.BLACK);
            Raylib.DrawText(enemy.HP.ToString(), 700, 20, 25, Color.BLACK);
        }
        if(gameStage == 2)        //de olika sluten till spelet
        {
            Raylib.DrawTextEx(default, "TIE", textPos, 20, 10, Color.BLACK);
            
        }
        if(gameStage == 3)
        {
            Raylib.DrawTextEx(default, "You Lose", textPos, 20, 10, Color.BLACK);
        }
        if(gameStage == 4)
        {
            player.Draw();

            Raylib.DrawTextEx(default, "Player HP:", textPosPHP, 20, 10, Color.BLACK);
            Raylib.DrawText(player.HP.ToString(), 250, 20, 25, Color.BLACK);

            Raylib.DrawTextEx(default, "You Won and Got a Health Potion", textPos, 20, 10, Color.BLACK);
            Raylib.DrawTextEx(default, "To Continue Go Right", textPos2, 20, 10, Color.BLACK);
        }
    }
}