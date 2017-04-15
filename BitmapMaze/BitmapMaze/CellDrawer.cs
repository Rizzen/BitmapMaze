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
    class CellDrawer
    {
        public static void DrawCell(DrawEventHandlerArgs a)
        {
            var g = Graphics.FromImage(a.bmp);
            var p = new Pen(Color.Black);
            g.dra
        }
    }
}
