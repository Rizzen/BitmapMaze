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
        private int XSize { get; }
        private int YSize { get; }

        public Maze (int _xSize, int _ySize, int CellSize)
        {
            XSize = _xSize;
            YSize = _ySize;

            cells = new Cell[XSize, YSize];

            for (int i = 0; i<YSize; i++)
            {
                for (int j = 0; j < XSize; j++)
                {
                    cells[j, i] = new Cell(j, i, CellSize);
                }
            }
        }

        public void DrawMaze(Bitmap bmp)
        {
            foreach (Cell c in cells)
            {
                c.Draw(bmp);
            }
            Console.WriteLine("Maze Succesfully Drawed!");
        }

        private List<Cell> GetNeighbours (Cell c)
        {
            var list = new List<Cell>();

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (c.X + i >= 0 && c.X + i < XSize && c.Y + j >= 0 && c.Y + j < YSize && Math.Abs(i)!= Math.Abs(j))
                    {
                        if (!cells[c.X + i, c.Y + j].IsVisited)
                        {
                            Console.WriteLine($"Added {c.X + i} {c.X + j} as Neighbour to {c.X} {c.Y}");
                            list.Add(cells[c.X + i, c.Y + j]);
                        }
                    }
                }
            }
            return list;
        }
        
        public void GenerateMaze(Bitmap bmp)
        {
            cells[0, 0].RemoveWallToCell(cells[0, 1]);
            cells[5, 5].RemoveWallToCell(cells[4, 5]);
            cells[5, 5].RemoveWallToCell(cells[5, 6]);
            // var startCell = cells[0, 0];
            // var g = Graphics.FromImage(bmp);
            // var b = new SolidBrush(Color.Green);

            /* var list = GetNeighbours(cells[0, 0]);

             foreach (Cell c in list)
             {
                 g.FillRectangle(b, c.X * c.Size, c.Y * c.Size, c.Size, c.Size);
             }*/

        }
    }
}
