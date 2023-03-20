global using Raylib_cs;
global using System.Numerics;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,600, "Slagsmålsspelet i 2D");

Area one = new Area();
Area2 two = new Area2();

while (!Raylib.WindowShouldClose())     //utritning av Area
{
    one.Update();

    if(one.gameStage == 5)
    {
        two.Update();
    }

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    one.Draw();

    if(one.gameStage == 5)
    {
        two.Draw();
    }
    

    Raylib.EndDrawing();
}