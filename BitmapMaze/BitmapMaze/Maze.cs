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

            for (int i = 0; i < YSize; i++)
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
                            Console.WriteLine($"Added {c.X + i} {c.Y + j} as Neighbour to {c.X} {c.Y}");
                            list.Add(cells[c.X + i, c.Y + j]);
                        }
                    }
                }
            }
            return list;
        }
        
        public void GenerateMaze()
        {
            var stack = new Stack<Cell>();
            var unVisited = new List<Cell>();
            var startCell = cells[0, 0];
            var currCell = startCell;
            var r = new Random();
            currCell.SetVisited();
            Cell neigbourCell;

            for (int i = 0; i < YSize; i++)
            {
                for (int j = 0; j < XSize; j++)
                {
                    unVisited.Add(cells[j, i]);
                }
            }

            while (unVisited.Count > 0)
            {
                var neigbourList = GetNeighbours(currCell);
                if (neigbourList.Count>0)
                {
                    int rand = r.Next(neigbourList.Count);
                    neigbourCell = neigbourList[rand];
                    unVisited.Remove(currCell);
                    currCell.RemoveWallToCell(neigbourCell);
                    stack.Push(currCell);
                    currCell = neigbourCell;
                    currCell.SetVisited();
                }
                else if (stack.Count > 0)
                {
                    currCell = stack.Pop();
                   
                }
                else
                {
                    currCell = unVisited[r.Next(unVisited.Count)];
                    currCell.IsVisited = true;
                    unVisited.Remove(currCell);
                    Console.WriteLine($"Random Choosen cell: {currCell.X} {currCell.Y}");
                }
            }
        }
    }
}
