using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tile_Maker
{
    public partial class Editor : Form
    {
        //Fields
        Form1 form1;
        PictureBox[,] map;

        Color brushColor; //Tracks current brush color in editor

        Color path;
        Color ocean;
        Color grass;
        Color entry;

        bool saved; //boolean to track whether form is saved

        OpenFileDialog fileDialog;

        int tileVisSize;

        //Tile tracking
        TileManager tileManager;

        //Constructor
        public Editor(Form1 form)
        {
            form1 = form;

            saved = true;

            tileVisSize = 30;

            path = Color.Wheat;
            ocean = Color.Aqua;
            grass = Color.ForestGreen;
            entry = Color.Crimson;

            tileManager = new TileManager();

            tileManager.LoadTiles();

            InitializeComponent();
        }

        //--------------------Buttons to track and set the color of the brush------------------

        private void colorButton1_Click(object sender, EventArgs e)
        {
            brushColor = ocean;
            selectedColor.BackColor = brushColor;
        }

        private void colorButton2_Click(object sender, EventArgs e)
        {
            brushColor = grass;
            selectedColor.BackColor = brushColor;
        }

        private void colorButton3_Click(object sender, EventArgs e)
        {
            brushColor = path;
            selectedColor.BackColor = brushColor;
        }

        private void colorButton4_Click(object sender, EventArgs e)
        {
            brushColor = entry;
            selectedColor.BackColor = brushColor;
        }


        /// <summary>
        /// Calls the save method which saves the current version of the level. Also changes the saved boolean to true
        /// </summary>
        /// <param name="sender">the save button</param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveTile();

            saved = true;
        }

        /// <summary>
        /// Opens the file dialog for the user to select a file and then load it into the editor with the load method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        { 
                LoadTile();
            
        }

        /// <summary>
        /// Changes the black color of clicked picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void map_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            pictureBox.BackColor = brushColor;

            if (saved)
            {
                this.Text = this.Text + "*";
            }


            saved = false;
           
        }

        /// <summary>
        /// Creates all of the picture boxes and sets the dimensions of the form to fit the map
        /// </summary>
        /// <param name="width">width of the map</param>
        /// <param name="height">height of the map</param>
        public void BuildMap(int width, int height)
        {
            map = new PictureBox[width, height];

            

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    map[i, j] = new PictureBox();
                    this.map[i, j].Location = new System.Drawing.Point( i * tileVisSize + 10,j * tileVisSize + 20);
                    this.map[i,j].Size = new System.Drawing.Size(tileVisSize, tileVisSize);
                    this.map[i, j].BackColor = grass;
                    this.map[i, j].Show();

                    this.map[i, j].Click += new System.EventHandler(this.map_Click);

                    this.mapBox.Controls.Add(map[i, j]);

                }
            }

            this.mapBox.Size = new System.Drawing.Size(width * tileVisSize + 20, height * tileVisSize + 30);
            this.ClientSize = new System.Drawing.Size(220 + width * tileVisSize, 650);

        }

        /// <summary>
        /// Loads the selected tile file from the open file dialog.
        /// </summary>
        /// <param name="file"></param>
        public void LoadTile()
        {

            if (TileSelectUI.Value == tileManager.tileList.Count)
            {
                BuildMap(7, 7);
            }
            else
            {


                BuildMap(tileManager[(int)TileSelectUI.Value].layout.GetLength(0), tileManager[(int)TileSelectUI.Value].layout.GetLength(1));

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        map[i, j].BackColor = DecodeColor(tileManager[(int)TileSelectUI.Value].layout[i, j]);
                    }
                }

            }

            MessageBox.Show("File Loaed successfully"); //confirmation of successful load

        }

        /// <summary>
        /// Saves the tile on the computer by writing to an IO Text file
        /// </summary>
        public void SaveTile()
        {
           

                for(int i = 0; i < map.GetLength(0); i++)
                {
                    for(int j = 0; j < map.GetLength(1)-1; j++)
                    {

                        tileManager[(int)TileSelectUI.Value].layout[i, j] = EncodeColor(map[i, j].BackColor);
                    }

                }

            tileManager.SaveTiles();

                MessageBox.Show("File saved successfully."); //Confirmation of save

          
        }

         

        /// <summary>
        /// Returns string symbol to represent the section of the tile
        /// </summary>
        /// <param name="color">set color of button that's data will then be used in the file saving</param>
        /// <returns>symbol </returns>
        private string EncodeColor(Color color)
        {
            if(color == ocean)
            {
                return "~";
            }
            if(color == path)
            {
                return "P";
            }
            if(color == grass)
            {
                return "G";
            }
            if(color == entry)
            {
                return "E";
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
                return ocean;
            }
            if (input == "P")
            {
                return path;
            }
            if (input == "G")
            {
                return grass;
            }
            if (input == "E")
            {
                return entry;
            }
            else
            {
                return grass;
            }
        }

        /// <summary>
        /// Checks with the user that they do or do not want to exit without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                e.Cancel = true;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show("There are unsaved changes.", " Are you sure you want to quit?", buttons);

                if (result == DialogResult.Yes)
                {
                    saved = true;
                    this.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TileSelectUI_ValueChanged(object sender, EventArgs e)
        {
            if((int)TileSelectUI.Value > tileManager.tileList.Count)
            {
                TileSelectUI.Value = tileManager.tileList.Count;
            }
            if(TileSelectUI.Value < 0)
            {
                TileSelectUI.Value = 0;
            }
        }
    }
}
