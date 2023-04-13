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
//Author Michael Steffler
//Date 3/20/22
namespace External_Tool
{
    public partial class Form1 : Form
    {
        private int basic;
        private int tank;
        private int fast;
        private int change;
        private StreamReader input;
        private StreamWriter output;
        private List<List<int>> waves;
        
        public Form1()
        {
            InitializeComponent();
            basic = 0;
            tank = 0;
            fast = 0;

            //Add more to add enemy types
            waves = new List<List<int>>();
            Setup();
            change = 1;
            

           
           
        }
        /// <summary>
        /// Adds selected enemy to current wave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(labelwaveNum.Text=="None")
            {
                MessageBox.Show("Select a wave");
                return;
            }
            switch (LabelCurrent.Text)
            {
                case ("Basic"):
                    basic += change;
                    labelBCount.Text = "" + basic;
                    break;
                case ("Tank"):
                    tank += change;
                    labelTCount.Text = "" + tank;
                    break;
                case ("Fast"):
                    fast += change;
                    labelF.Text = "" + fast;
                    break;
                //Add more to add enemy types
                default:
                    break;
            }
            waves[int.Parse(textBoxWaveNum.Text) - 1][0] = basic;
            waves[int.Parse(textBoxWaveNum.Text) - 1][1] = tank;
            waves[int.Parse(textBoxWaveNum.Text) - 1][2] = fast;
            //Add more to add enemy types
        }


        /// <summary>
        /// selects enemy to change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBasic_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            LabelCurrent.Text = b.Text;
        }

      
        /// <summary>
        /// saves waves to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSW_Click(object sender, EventArgs e)
        {

            StreamWriter output = new StreamWriter("wave.txt");
            foreach (List<int> item in waves)
            {
                output.WriteLine(item[0] + "," + item[1]+","+item[2]);
                //Add more to add enemy types
            }

            output.Close();
            MessageBox.Show("File saved");
            
        }
        /// <summary>
        /// changes the current wave 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWaveNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxWaveNum.Text) > -1 && int.Parse(textBoxWaveNum.Text) <= waves.Count)
                {
                    basic = waves[int.Parse(textBoxWaveNum.Text) - 1][0];
                    tank = waves[int.Parse(textBoxWaveNum.Text) - 1][1];
                    fast = waves[int.Parse(textBoxWaveNum.Text) - 1][2];
                    labelBCount.Text = "" + basic;
                    labelTCount.Text = "" + tank;
                    labelF.Text = "" + fast;
                    labelwaveNum.Text = "" + int.Parse(textBoxWaveNum.Text);
                    //Add more to add enemy types
                }
            }
            catch(Exception)
            {

            }
               
            

        }
        /// <summary>
        /// sets up all the waves in list
        /// </summary>
        private void Setup()
        {
            for (int i = 0; i < 200; i++)
            {
                List<int> n = new List<int>();
                n.Add(0);
                n.Add(0);
                n.Add(0);
                //Add more as enemy types increase
                waves.Add(n);
            }
            basic = waves[1- 1][0];
            tank = waves[1 - 1][1];
            fast = waves[1 - 1][2];
            labelBCount.Text = "" + basic;
            labelTCount.Text = "" + tank;
            labelF.Text = "" + fast; 
            labelwaveNum.Text = "" + int.Parse(textBoxWaveNum.Text);
        }
        /// <summary>
        /// loads waves from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                input = new StreamReader("wave.txt");
            }
            catch(Exception)
            {
                MessageBox.Show("Error loading file");
                return;
            }
            
            for (int i = 0; i < 200; i++)
            {
                string holder = input.ReadLine();
                String[] data= holder.Split(",");
                waves[i][0] = int.Parse(data[0]);
                waves[i][1] = int.Parse(data[1]);
                waves[i][2] = int.Parse(data[2]);

            }
            input.Close();
            basic = waves[int.Parse(textBoxWaveNum.Text) - 1][0];
            tank = waves[int.Parse(textBoxWaveNum.Text) - 1][1];
            fast = waves[int.Parse(textBoxWaveNum.Text) - 1][2];
            labelBCount.Text = "" + basic;
            labelTCount.Text = "" + tank;
            labelF.Text = "" + fast;
            labelwaveNum.Text = "" + int.Parse(textBoxWaveNum.Text);
            //Add more to add enemy types
            MessageBox.Show("Waves loaded");

        }
        /// <summary>
        /// subtracts selected enemy from current wave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (labelwaveNum.Text == "None")
            {
                MessageBox.Show("Select a wave");
                return;
            }
            switch (LabelCurrent.Text)
            {
                case ("Basic"):
                    basic-=change;
                    if(basic<0)
                    {
                        basic = 0;
                    }
                    labelBCount.Text = "" + basic;
                    break;
                case ("Tank"):
                    tank-= change;
                    if (tank < 0)
                    {
                        tank = 0;
                    }
                    labelTCount.Text = "" + tank;
                    break;
                case ("Fast"):
                    fast -= change;
                    if (fast < 0)
                    {
                        fast = 0;
                    }
                    labelF.Text = "" + fast;
                    break;

                //Add more to add enemy types
                default:
                    break;
            }
            waves[int.Parse(textBoxWaveNum.Text) - 1][0] = basic;
            waves[int.Parse(textBoxWaveNum.Text) - 1][1] = tank;
            waves[int.Parse(textBoxWaveNum.Text) - 1][2] = fast;
            //Add more to add enemy types
        }

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxChange.Text) > -1 )
                {
                    change = int.Parse(textBoxChange.Text);
                }
            }
            catch (Exception)
            {
                textBoxChange.Text = ""+1;
            }
        }
    }
}
