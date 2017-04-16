using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;


namespace BitmapMaze
{
    static class Program
    {

        static void Main(string[] args)
        {
            const int CELL_SIZE = 30;
            const int MAZE_X = 10;
            const int MAZE_Y = 10;

            var bmp = new Bitmap(MAZE_X * CELL_SIZE + 1, MAZE_Y * CELL_SIZE + 1);
            var g = Graphics.FromImage(bmp);
            var b = new SolidBrush(Color.White);
            g.FillRectangle(b, 0, 0, bmp.Width, bmp.Height);
            g?.Dispose();
            b?.Dispose();
            
            var maze = new Maze(MAZE_X, MAZE_Y, CELL_SIZE);
            
            maze.GenerateMaze(bmp);
            maze.DrawMaze(bmp);

            bmp.Save($"bmp{DateTimeOffset.Now.ToUnixTimeSeconds()}.bmp");
           
            Console.WriteLine(Image.GetPixelFormatSize(bmp.PixelFormat));
            Console.ReadLine();
        }
    }
}