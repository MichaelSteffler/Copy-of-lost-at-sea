using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile_Maker
{
    class Point
    {
        int x;
        int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
    }
}
