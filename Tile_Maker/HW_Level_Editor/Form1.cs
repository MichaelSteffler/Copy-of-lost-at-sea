using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tile_Maker
{
    public partial class Form1 : Form
    {
        private Editor editor;

        public Form1()
        {
            
            editor = new Editor(this);
            InitializeComponent();
        }

        /// <summary>
        /// Initializes editor to load in a new tile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        /// <summary>
        /// creates a blank tile for the user to draw on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
                    editor.BuildMap(7, 7);
                    editor.Show();
        }
    }
}
