global using Raylib_cs;
global using System.Numerics;

Raylib.SetTargetFPS(60);
Raylib.InitWindow(800,600, "Slagsmålsspelet i 2D");

// gameStart start = new gameStart();
Area hoth = new Area();
// gameEnd end = new gameEnd();

while (!Raylib.WindowShouldClose())     //utritning av Area
{
    hoth.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    hoth.Draw();
    Raylib.EndDrawing();
}