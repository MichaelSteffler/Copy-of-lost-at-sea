
namespace Tile_Maker
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorButton4 = new System.Windows.Forms.Button();
            this.colorButton3 = new System.Windows.Forms.Button();
            this.colorButton2 = new System.Windows.Forms.Button();
            this.colorButton1 = new System.Windows.Forms.Button();
            this.choiceBox = new System.Windows.Forms.GroupBox();
            this.selectedColor = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.mapBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TileSelectUI = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.choiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TileSelectUI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colorButton4);
            this.groupBox1.Controls.Add(this.colorButton3);
            this.groupBox1.Controls.Add(this.colorButton2);
            this.groupBox1.Controls.Add(this.colorButton1);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tile Selector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ocean";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grass";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // colorButton4
            // 
            this.colorButton4.BackColor = System.Drawing.Color.Crimson;
            this.colorButton4.Location = new System.Drawing.Point(81, 101);
            this.colorButton4.Name = "colorButton4";
            this.colorButton4.Size = new System.Drawing.Size(62, 63);
            this.colorButton4.TabIndex = 4;
            this.colorButton4.UseVisualStyleBackColor = false;
            this.colorButton4.Click += new System.EventHandler(this.colorButton4_Click);
            // 
            // colorButton3
            // 
            this.colorButton3.BackColor = System.Drawing.Color.Wheat;
            this.colorButton3.Location = new System.Drawing.Point(6, 101);
            this.colorButton3.Name = "colorButton3";
            this.colorButton3.Size = new System.Drawing.Size(62, 63);
            this.colorButton3.TabIndex = 3;
            this.colorButton3.UseVisualStyleBackColor = false;
            this.colorButton3.Click += new System.EventHandler(this.colorButton3_Click);
            // 
            // colorButton2
            // 
            this.colorButton2.BackColor = System.Drawing.Color.ForestGreen;
            this.colorButton2.Location = new System.Drawing.Point(81, 19);
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(61, 63);
            this.colorButton2.TabIndex = 1;
            this.colorButton2.UseVisualStyleBackColor = false;
            this.colorButton2.Click += new System.EventHandler(this.colorButton2_Click);
            // 
            // colorButton1
            // 
            this.colorButton1.BackColor = System.Drawing.Color.Aqua;
            this.colorButton1.Location = new System.Drawing.Point(6, 19);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(62, 63);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.UseVisualStyleBackColor = false;
            this.colorButton1.Click += new System.EventHandler(this.colorButton1_Click);
            // 
            // choiceBox
            // 
            this.choiceBox.Controls.Add(this.selectedColor);
            this.choiceBox.Location = new System.Drawing.Point(9, 213);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(148, 87);
            this.choiceBox.TabIndex = 1;
            this.choiceBox.TabStop = false;
            this.choiceBox.Text = "Current Tile";
            // 
            // selectedColor
            // 
            this.selectedColor.BackColor = System.Drawing.SystemColors.Control;
            this.selectedColor.Location = new System.Drawing.Point(34, 26);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(71, 48);
            this.selectedColor.TabIndex = 0;
            this.selectedColor.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 436);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 74);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(9, 356);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(148, 74);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(177, 23);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(512, 436);
            this.mapBox.TabIndex = 4;
            this.mapBox.TabStop = false;
            this.mapBox.Text = "Map";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TileSelectUI);
            this.groupBox2.Location = new System.Drawing.Point(9, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 44);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tile Select";
            // 
            // TileSelectUI
            // 
            this.TileSelectUI.Location = new System.Drawing.Point(9, 18);
            this.TileSelectUI.Name = "TileSelectUI";
            this.TileSelectUI.Size = new System.Drawing.Size(119, 20);
            this.TileSelectUI.TabIndex = 0;
            this.TileSelectUI.ValueChanged += new System.EventHandler(this.TileSelectUI_ValueChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 527);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.choiceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TileSelectUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button colorButton3;
        private System.Windows.Forms.Button colorButton2;
        private System.Windows.Forms.Button colorButton1;
        private System.Windows.Forms.GroupBox choiceBox;
        private System.Windows.Forms.PictureBox selectedColor;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox mapBox;
        private System.Windows.Forms.Button colorButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown TileSelectUI;
    }
}