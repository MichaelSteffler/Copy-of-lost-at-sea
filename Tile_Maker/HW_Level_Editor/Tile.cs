using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile_Maker
{
    public enum ScanDir
    {
        Up,
        Down,
        Left,
        Right
    }
    class Tile
    {
        public string[,] layout;

        public List<Point> path;



        public String this[int i, int j]
        {
            get { return layout[i, j]; }
            set { layout[i, j] = value; }
        }

        //Constructor
        public Tile(string[,] layout)
        {
            this.layout = layout;
            path = new List<Point>();
        }


        /// <summary>
        /// loops through tile grid and check if each node in the tile are corners or not
        /// </summary>
        public void BuildPath()
        {
            path.Add(new Point(3, 0));
            for(int y = 0; y < layout.GetLength(0); y++)
            {
                for(int x = 0; x < layout.GetLength(1); x++)
                {
                    if (CheckIfCorner(x, y))
                    {
                        path.Add(new Point(x, y));
                    }
                }
            }
                
        } 
        
        private bool CheckIfCorner(int x, int y)
        {
            bool up = (y - 1 >= 0 && layout[x, y - 1] == "P");
            bool down = (y + 1 <= 6 && layout[x, y + 1] == "P");
            bool left = (x - 1 >= 0 && layout[x - 1, y] == "P");
            bool right = (x + 1 <= 6 && layout[x + 1, y] == "P");

            return up && left || left && down || down && right || right && up;
        }
    }
}
