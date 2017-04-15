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

        
        
        public Cell(int _x, int _y, int _size)
        {
            X = _x;
            Y = _y;
            Size = _size;
        }
        /// <summary>
        /// 0 - no way, 1 - way;
        /// 0th element - up;
        /// 1th element - right;
        /// 2th element - down;
        /// 3th element - left;
        /// </summary>
        public int[] AdjacencyList = new int[] { 0, 0, 0, 0 }; 

        public void Draw (Bitmap bmp)
        {
            var g = Graphics.FromImage(bmp);
            var p = new Pen(Color.Black);

            if (AdjacencyList[0] == 0) g.DrawLine(p, new Point(X * Size, Y * Size), new Point(X * Size + Size, Y * Size));
            if (AdjacencyList[1] == 0) g.DrawLine(p, new Point(X * Size + Size, Y * Size), new Point(X * Size + Size, Y * Size + Size));
            if (AdjacencyList[2] == 0) g.DrawLine(p, new Point(X * Size + Size, Y * Size + Size), new Point(X * Size, Y * Size + Size));
            if (AdjacencyList[3] == 0) g.DrawLine(p, new Point(X * Size, Y * Size + Size), new Point(X * Size, Y * Size));

          /*  g.DrawLines(p,
                new Point[]
                {
                    new Point (X*Size,Y*Size),
                    new Point (X*Size+Size,Y*Size),
                    new Point (X*Size+Size,Y*Size+Size),
                    new Point (X*Size,Y*Size+Size),
                    new Point (X*Size,Y*Size)
                });*/
            g?.Dispose();
            p?.Dispose();

        Console.WriteLine($"Drawed Cell {X},{Y}.");
        }
        /// <summary>
        /// Это не нужно
        /// </summary>
        /// <param name="w"></param>
        /// <param name="bmp"></param>
        public void RemoveWall(Wall w, Bitmap bmp)
        {
            var g = Graphics.FromImage(bmp);
            var p = new Pen(Color.White);

            switch (w)
            {
                case Wall.Up:
                    g.DrawLine(p, new Point(X * Size, Y * Size), new Point(X * Size + Size, Y * Size));
                    break;
                case Wall.Down:
                    g.DrawLine(p, new Point(X * Size + Size, Y * Size + Size), new Point(X * Size, Y * Size + Size));
                    break;
                case Wall.Right:
                    g.DrawLine(p, new Point(X * Size + Size, Y * Size), new Point(X * Size + Size, Y * Size + Size));
                    break;
                case Wall.Left:
                    g.DrawLine(p, new Point(X * Size, Y * Size + Size), new Point(X * Size, Y * Size));
                    break;
            }
        }

        //public void Draw (DrawEventHandlerArgs a) => OnDraw(a);
        //public event CellDraw OnDraw;
    }
}
