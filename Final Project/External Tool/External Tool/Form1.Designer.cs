
namespace External_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxWaveNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSW = new System.Windows.Forms.Button();
            this.buttonTank = new System.Windows.Forms.Button();
            this.buttonBasic = new System.Windows.Forms.Button();
            this.LabelCurrent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelwaveNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxChange);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonSubtract);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.textBoxWaveNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSW);
            this.groupBox1.Controls.Add(this.buttonTank);
            this.groupBox1.Controls.Add(this.buttonBasic);
            this.groupBox1.Controls.Add(this.LabelCurrent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(360, 627);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Fast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonBasic_Click);
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(196, 363);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(71, 31);
            this.textBoxChange.TabIndex = 12;
            this.textBoxChange.Text = "1";
            this.textBoxChange.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.Location = new System.Drawing.Point(20, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount to change: ";
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(206, 408);
            this.buttonSubtract.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(124, 80);
            this.buttonSubtract.TabIndex = 10;
            this.buttonSubtract.Text = "Subtract";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(59, 557);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(246, 37);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load Waves";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxWaveNum
            // 
            this.textBoxWaveNum.Location = new System.Drawing.Point(83, 243);
            this.textBoxWaveNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxWaveNum.Name = "textBoxWaveNum";
            this.textBoxWaveNum.Size = new System.Drawing.Size(155, 31);
            this.textBoxWaveNum.TabIndex = 8;
            this.textBoxWaveNum.Text = "1";
            this.textBoxWaveNum.TextChanged += new System.EventHandler(this.textBoxWaveNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wave:";
            // 
            // buttonSW
            // 
            this.buttonSW.Location = new System.Drawing.Point(59, 513);
            this.buttonSW.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSW.Name = "buttonSW";
            this.buttonSW.Size = new System.Drawing.Size(246, 37);
            this.buttonSW.TabIndex = 6;
            this.buttonSW.Text = "Save Waves";
            this.buttonSW.UseVisualStyleBackColor = true;
            this.buttonSW.Click += new System.EventHandler(this.buttonSW_Click);
            // 
            // buttonTank
            // 
            this.buttonTank.Location = new System.Drawing.Point(174, 93);
            this.buttonTank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTank.Name = "buttonTank";
            this.buttonTank.Size = new System.Drawing.Size(117, 37);
            this.buttonTank.TabIndex = 5;
            this.buttonTank.Text = "Tank";
            this.buttonTank.UseVisualStyleBackColor = true;
            this.buttonTank.Click += new System.EventHandler(this.buttonBasic_Click);
            // 
            // buttonBasic
            // 
            this.buttonBasic.Location = new System.Drawing.Point(26, 93);
            this.buttonBasic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBasic.Name = "buttonBasic";
            this.buttonBasic.Size = new System.Drawing.Size(117, 37);
            this.buttonBasic.TabIndex = 4;
            this.buttonBasic.Text = "Basic";
            this.buttonBasic.UseVisualStyleBackColor = true;
            this.buttonBasic.Click += new System.EventHandler(this.buttonBasic_Click);
            // 
            // LabelCurrent
            // 
            this.LabelCurrent.AutoSize = true;
            this.LabelCurrent.Location = new System.Drawing.Point(174, 40);
            this.LabelCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrent.Name = "LabelCurrent";
            this.LabelCurrent.Size = new System.Drawing.Size(55, 25);
            this.LabelCurrent.TabIndex = 3;
            this.LabelCurrent.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected enemy: ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 408);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(124, 80);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(4, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(31, 597);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic:";
            // 
            // labelBCount
            // 
            this.labelBCount.AutoSize = true;
            this.labelBCount.Location = new System.Drawing.Point(513, 53);
            this.labelBCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBCount.Name = "labelBCount";
            this.labelBCount.Size = new System.Drawing.Size(22, 25);
            this.labelBCount.TabIndex = 2;
            this.labelBCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanks: ";
            // 
            // labelTCount
            // 
            this.labelTCount.AutoSize = true;
            this.labelTCount.Location = new System.Drawing.Point(643, 53);
            this.labelTCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTCount.Name = "labelTCount";
            this.labelTCount.Size = new System.Drawing.Size(22, 25);
            this.labelTCount.TabIndex = 4;
            this.labelTCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wave:  ";
            // 
            // labelwaveNum
            // 
            this.labelwaveNum.AutoSize = true;
            this.labelwaveNum.Location = new System.Drawing.Point(513, 17);
            this.labelwaveNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelwaveNum.Name = "labelwaveNum";
            this.labelwaveNum.Size = new System.Drawing.Size(55, 25);
            this.labelwaveNum.TabIndex = 6;
            this.labelwaveNum.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(698, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fast:";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(751, 53);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(59, 25);
            this.labelF.TabIndex = 8;
            this.labelF.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 627);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelwaveNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelBCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonTank;
        private System.Windows.Forms.Button buttonBasic;
        private System.Windows.Forms.Label LabelCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTCount;
        private System.Windows.Forms.Button buttonSW;
        private System.Windows.Forms.TextBox textBoxWaveNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelwaveNum;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelF;
    }
}

