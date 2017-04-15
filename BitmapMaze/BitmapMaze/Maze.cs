using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace BitmapMaze
{
    class Maze
    {
        private Cell[,] cells;

        public Maze (int XSize, int YSize, int CellSize)
        {
            cells = new Cell[XSize, YSize];

            for (int i = 0; i<YSize; i++)
            {
                for (int j = 0; j < XSize; j++)
                {
                    cells[i, j] = new Cell(j, i, CellSize);
                }
            }
        }

        public void DrawMaze(Bitmap bmp)
        {
            foreach (Cell c in cells)
            {
                c.Draw(bmp);
            }
            Console.WriteLine("Maze Succesfully Drawed!!");
        }
        
        public void GenerateMaze(Bitmap bmp)
        {

        }
    }
}
