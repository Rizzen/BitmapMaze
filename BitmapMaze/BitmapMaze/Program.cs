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
            const int CELL_SIZE = 20;
            const int MAZE_X = 10;
            const int MAZE_Y = 7;

            var cells = new int[MAZE_X, MAZE_Y];
            var bmp = new Bitmap(MAZE_X * CELL_SIZE + 1, MAZE_Y * CELL_SIZE + 1);

            var g = Graphics.FromImage(bmp);
            var p = new Pen(Color.Black);
            for (int i = 0; i < MAZE_X; i++)
            {
                for (int j = 0; j < MAZE_Y; j++)
                {
                    g.DrawRectangle(p, i * CELL_SIZE, j * CELL_SIZE, CELL_SIZE, CELL_SIZE);
                    Console.WriteLine($"DRAWED {i} {j}");
                }
            }

            bmp.Save($"bmp{DateTimeOffset.Now.ToUnixTimeSeconds()}.bmp");

            Console.ReadLine();
        }
    }
}