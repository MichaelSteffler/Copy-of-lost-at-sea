using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Tile_Maker
{
    class TileManager
    {
        public List<Tile> tileList;

        public Tile this[int index]
        {
            get
            {
                return tileList[index];
            }

            set
            {
                tileList[index] = value;
            }
        }

        public TileManager()
        {
            tileList = new List<Tile>();
        }

        

        public void AddTile(PictureBox[,] map)
        {
            string[,] maptemp = new string[map.GetLength(0), map.GetLength(1)];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1) - 1; j++)
                {

                   maptemp[i,j] = EncodeColor(map[i, j].BackColor);
                }
                maptemp[i,map.GetLength(1) - 1] = EncodeColor(map[i, map.GetLength(1) - 1].BackColor);
            }

            Tile tile = new Tile(maptemp);

            

            tile.BuildPath();

            tileList.Add(tile);
        }

        public void SaveTiles()
        {
            
            StreamWriter writer = new StreamWriter("Tiles.txt");

            writer.WriteLine(tileList.Count);

            foreach(Tile tile in tileList)
            {
                

                for (int i = 0; i < tile.layout.GetLength(0); i++)
                {
                    for (int j = 0; j < tile.layout.GetLength(1) - 1; j++)
                    {

                        writer.Write(tile.layout[i, j]);
                    }
                    writer.WriteLine(tile.layout[i, tile.layout.GetLength(1) - 1]);
                }

                if(tile.path == null)
                {
                    tile.BuildPath();
                }

                writer.WriteLine(tile.path.Count);
                foreach(Point p in tile.path)
                {
                    writer.WriteLine(p.X + " " + p.Y);
                }

                writer.WriteLine();
            }

            writer.Close();
            
        }

        public void LoadTiles()
        {

            StreamReader reader = new StreamReader("Tiles.txt");

            int totalTiles = int.Parse(reader.ReadLine());

            for(int k = 0; k < totalTiles; k++)
            {
                Tile tile;

                string[,] tempMap = new string[7, 7];


                for (int i = 0; i < 7; i++)
                {
                    string row = reader.ReadLine();
                    for (int j = 0; j < 7; j++)
                    {

                        tempMap[i,j] = row[j].ToString();
                    }
                }

                int cornerNum = int.Parse(reader.ReadLine());

                

                tile = new Tile(tempMap);

                for (int i = 0; i < cornerNum; i++)
                {
                    string coords = reader.ReadLine();
                    tile.path.Add(new Point(int.Parse(coords[0].ToString()), int.Parse(coords[2].ToString())));
                }

                reader.ReadLine();

                tileList.Add(tile);

                reader.Close();
            }

        }

        private string EncodeColor(Color color)
        { 
            if (color == Color.Aqua)
            {
                return "~";
            }
            if (color == Color.Wheat)
            {
                return "P";
            }
            if (color == Color.ForestGreen)
            {
                return "G";
            }
            if (color == Color.Crimson)
            {
                return "P";
            }
            else
            {
                return "X";
            }
        }

        private Color DecodeColor(string input)
        {
            if (input == "~")
            {
                return Color.Aqua;
            }
            if (input == "P")
            {
                return Color.Wheat;
            }
            if (input == "G")
            {
                return Color.ForestGreen;
            }
            
            else
            {
                return Color.ForestGreen;
            }
        }

   


    }
}
