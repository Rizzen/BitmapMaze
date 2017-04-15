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

        public void Draw (Bitmap bmp)
        {

        }

        //public void Draw (DrawEventHandlerArgs a) => OnDraw(a);
        //public event CellDraw OnDraw;
    }
}
