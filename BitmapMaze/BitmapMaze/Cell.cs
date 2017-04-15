using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitmapMaze.Handlers;
using BitmapMaze.Args;

namespace BitmapMaze
{
    class Cell
    {
        private int X { get; }
        private int Y { get; }
        private int Size { get; }
        
        public void Draw (DrawEventHandlerArgs a) => OnDraw(a);
        public event CellDraw OnDraw;
    }
}
