using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitmapMaze.Handlers;
using BitmapMaze.Args;
using System.Drawing;
using System.Drawing.Imaging;

namespace BitmapMaze
{
    class Cell
    {
        private int X { get; }
        private int Y { get; }
        private int Size { get; }

        public List<Cell> AdjacencyList = new List<Cell>();
        
        public Cell(int _x, int _y, int _size)
        {
            X = _x;
            Y = _y;
            Size = _size;
        }

        public void Draw (Bitmap bmp)
        {
            var g = Graphics.FromImage(bmp);
            var p = new Pen(Color.Black);
            g.DrawLines(p,
               new Point[]
                {
                    new Point (X*Size,Y*Size),
                    new Point (X*Size+Size,Y*Size),
                    new Point (X*Size+Size,Y*Size+Size),
                    new Point (X*Size,Y*Size+Size),
                    new Point (X*Size,Y*Size)
                }
            );
            Console.WriteLine($"Drawed Cell {X},{Y}.");
        }

        //public void Draw (DrawEventHandlerArgs a) => OnDraw(a);
        //public event CellDraw OnDraw;
    }
}
