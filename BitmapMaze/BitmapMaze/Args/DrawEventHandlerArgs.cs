using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace BitmapMaze.Args
{
    public class DrawEventHandlerArgs: EventArgs
    {
        public int X { get; }
        public int Y { get; }
        public int Size { get; }
        public Bitmap bmp { get; }
    }
}
