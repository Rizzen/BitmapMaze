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
            const int CELL_SIZE = 15;
            const int MAZE_X = 1000;
            const int MAZE_Y = 1000;

            //var cells = new int[MAZE_X, MAZE_Y];
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

            for (int i = 0; i < bmp.Size.Height; i++)
            {
                for (int j = 0; j < bmp.Size.Width; j++)
                {
                    bmp.SetPixel(i,j, Color.Red);
                    Console.WriteLine($" {i} {j} {bmp.GetPixel(i, j)} ");
                }
            }

           bmp.Save($"bmp{DateTimeOffset.Now.ToUnixTimeSeconds()}.bmp");
           
            Console.WriteLine(Image.GetPixelFormatSize(bmp.PixelFormat));
            Console.ReadLine();
        }
    }
}