# BitmapMaze
Generate maze with Depth-first search based algorithm and draw it to BMP picture.
## Demo
``` C#
static void Main(string[] args)
{
    const int CELL_SIZE = 30;
    const int MAZE_X = 100;
    const int MAZE_Y = 100;

    var bmp = new Bitmap(MAZE_X * CELL_SIZE + 1, MAZE_Y * CELL_SIZE + 1);           
    var maze = new Maze(MAZE_X, MAZE_Y, CELL_SIZE);
            
    maze.GenerateMaze();
    maze.DrawMaze(bmp);
    bmp.Save($"bmp{DateTimeOffset.Now.ToUnixTimeSeconds()}.bmp");
}
```
