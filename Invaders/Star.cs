using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    class Star
    {
        public Point point;
        public Brush brush;

        public Star(Point point, Brush brush)
        {
            this.point = point;
            this.brush = brush;
        }
    }
}
