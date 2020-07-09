namespace Pots_Model
{
    partial class FormPotsModel
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.pictureBoxSpinSite = new System.Windows.Forms.PictureBox();
            this.labeldata = new System.Windows.Forms.Label();
            this.numericUpDownIt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBox_nEqui = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_dT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Tend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Tfirst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MCS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPic = new System.Windows.Forms.GroupBox();
            this.checkBox_ShowSpin = new System.Windows.Forms.CheckBox();
            this.trackBar_Latency = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox_PlotC = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlotEAve = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlotMAve = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlotX = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonClearGraphs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpinSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIt)).BeginInit();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Latency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotEAve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotMAve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotX)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 47);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(52, 252);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(63, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pictureBoxSpinSite
            // 
            this.pictureBoxSpinSite.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxSpinSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSpinSite.Location = new System.Drawing.Point(12, 77);
            this.pictureBoxSpinSite.Name = "pictureBoxSpinSite";
            this.pictureBoxSpinSite.Size = new System.Drawing.Size(381, 295);
            this.pictureBoxSpinSite.TabIndex = 3;
            this.pictureBoxSpinSite.TabStop = false;
            this.pictureBoxSpinSite.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSpinSite_Paint);
            // 
            // labeldata
            // 
            this.labeldata.AutoSize = true;
            this.labeldata.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldata.Location = new System.Drawing.Point(405, 425);
            this.labeldata.Name = "labeldata";
            this.labeldata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labeldata.Size = new System.Drawing.Size(70, 14);
            this.labeldata.TabIndex = 4;
            this.labeldata.Text = "labelData";
            // 
            // numericUpDownIt
            // 
            this.numericUpDownIt.Location = new System.Drawing.Point(342, 33);
            this.numericUpDownIt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIt.Name = "numericUpDownIt";
            this.numericUpDownIt.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownIt.TabIndex = 5;
            this.numericUpDownIt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Take a sample every";
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBox_nEqui);
            this.groupBoxCondition.Controls.Add(this.label11);
            this.groupBoxCondition.Controls.Add(this.textBox_q);
            this.groupBoxCondition.Controls.Add(this.label9);
            this.groupBoxCondition.Controls.Add(this.label8);
            this.groupBoxCondition.Controls.Add(this.textBox_dT);
            this.groupBoxCondition.Controls.Add(this.label6);
            this.groupBoxCondition.Controls.Add(this.textBox_Tend);
            this.groupBoxCondition.Controls.Add(this.label5);
            this.groupBoxCondition.Controls.Add(this.textBox_Tfirst);
            this.groupBoxCondition.Controls.Add(this.buttonReset);
            this.groupBoxCondition.Controls.Add(this.label4);
            this.groupBoxCondition.Controls.Add(this.textBox_MCS);
            this.groupBoxCondition.Controls.Add(this.label3);
            this.groupBoxCondition.Controls.Add(this.textBox_L);
            this.groupBoxCondition.Controls.Add(this.label2);
            this.groupBoxCondition.Location = new System.Drawing.Point(402, 73);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(127, 291);
            this.groupBoxCondition.TabIndex = 7;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "System";
            this.groupBoxCondition.Enter += new System.EventHandler(this.groupBoxCondition_Enter);
            // 
            // textBox_nEqui
            // 
            this.textBox_nEqui.Location = new System.Drawing.Point(52, 44);
            this.textBox_nEqui.Name = "textBox_nEqui";
            this.textBox_nEqui.Size = new System.Drawing.Size(63, 20);
            this.textBox_nEqui.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "MonteCarlo steps\r\nfor Initialize spins";
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(52, 88);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(63, 20);
            this.textBox_q.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "q";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "(J/K)";
            // 
            // textBox_dT
            // 
            this.textBox_dT.Location = new System.Drawing.Point(52, 220);
            this.textBox_dT.Name = "textBox_dT";
            this.textBox_dT.Size = new System.Drawing.Size(63, 20);
            this.textBox_dT.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "dT";
            // 
            // textBox_Tend
            // 
            this.textBox_Tend.Location = new System.Drawing.Point(52, 201);
            this.textBox_Tend.Name = "textBox_Tend";
            this.textBox_Tend.Size = new System.Drawing.Size(63, 20);
            this.textBox_Tend.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tsecond";
            // 
            // textBox_Tfirst
            // 
            this.textBox_Tfirst.Location = new System.Drawing.Point(52, 182);
            this.textBox_Tfirst.Name = "textBox_Tfirst";
            this.textBox_Tfirst.Size = new System.Drawing.Size(63, 20);
            this.textBox_Tfirst.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tfirst";
            // 
            // textBox_MCS
            // 
            this.textBox_MCS.Location = new System.Drawing.Point(52, 144);
            this.textBox_MCS.Name = "textBox_MCS";
            this.textBox_MCS.Size = new System.Drawing.Size(63, 20);
            this.textBox_MCS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "MonteCarlo steps\r\nfor each Temperature";
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(52, 67);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(63, 20);
            this.textBox_L.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "L";
            // 
            // groupBoxPic
            // 
            this.groupBoxPic.Controls.Add(this.checkBox_ShowSpin);
            this.groupBoxPic.Location = new System.Drawing.Point(402, 367);
            this.groupBoxPic.Name = "groupBoxPic";
            this.groupBoxPic.Size = new System.Drawing.Size(127, 48);
            this.groupBoxPic.TabIndex = 8;
            this.groupBoxPic.TabStop = false;
            this.groupBoxPic.Text = "Show Graphics";
            // 
            // checkBox_ShowSpin
            // 
            this.checkBox_ShowSpin.AutoSize = true;
            this.checkBox_ShowSpin.Checked = true;
            this.checkBox_ShowSpin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShowSpin.Location = new System.Drawing.Point(11, 23);
            this.checkBox_ShowSpin.Name = "checkBox_ShowSpin";
            this.checkBox_ShowSpin.Size = new System.Drawing.Size(52, 17);
            this.checkBox_ShowSpin.TabIndex = 0;
            this.checkBox_ShowSpin.Text = "Spins";
            this.checkBox_ShowSpin.UseVisualStyleBackColor = true;
            // 
            // trackBar_Latency
            // 
            this.trackBar_Latency.Location = new System.Drawing.Point(541, 28);
            this.trackBar_Latency.Name = "trackBar_Latency";
            this.trackBar_Latency.Size = new System.Drawing.Size(126, 45);
            this.trackBar_Latency.TabIndex = 9;
            this.trackBar_Latency.Value = 8;
            this.trackBar_Latency.ValueChanged += new System.EventHandler(this.trackBarLatency_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Latency ( time interval between two showing )";
            // 
            // pictureBox_PlotC
            // 
            this.pictureBox_PlotC.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_PlotC.Location = new System.Drawing.Point(544, 74);
            this.pictureBox_PlotC.Name = "pictureBox_PlotC";
            this.pictureBox_PlotC.Size = new System.Drawing.Size(309, 244);
            this.pictureBox_PlotC.TabIndex = 11;
            this.pictureBox_PlotC.TabStop = false;
            this.pictureBox_PlotC.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_PlotC_Paint);
            // 
            // pictureBox_PlotEAve
            // 
            this.pictureBox_PlotEAve.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_PlotEAve.Location = new System.Drawing.Point(544, 322);
            this.pictureBox_PlotEAve.Name = "pictureBox_PlotEAve";
            this.pictureBox_PlotEAve.Size = new System.Drawing.Size(309, 244);
            this.pictureBox_PlotEAve.TabIndex = 12;
            this.pictureBox_PlotEAve.TabStop = false;
            this.pictureBox_PlotEAve.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_PlotEAve_Paint);
            // 
            // pictureBox_PlotMAve
            // 
            this.pictureBox_PlotMAve.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_PlotMAve.Location = new System.Drawing.Point(859, 322);
            this.pictureBox_PlotMAve.Name = "pictureBox_PlotMAve";
            this.pictureBox_PlotMAve.Size = new System.Drawing.Size(309, 244);
            this.pictureBox_PlotMAve.TabIndex = 13;
            this.pictureBox_PlotMAve.TabStop = false;
            this.pictureBox_PlotMAve.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_PlotMAve_Paint);
            // 
            // pictureBox_PlotX
            // 
            this.pictureBox_PlotX.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_PlotX.Location = new System.Drawing.Point(859, 74);
            this.pictureBox_PlotX.Name = "pictureBox_PlotX";
            this.pictureBox_PlotX.Size = new System.Drawing.Size(309, 244);
            this.pictureBox_PlotX.TabIndex = 14;
            this.pictureBox_PlotX.TabStop = false;
            this.pictureBox_PlotX.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_PlotX_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.aboutToolStripMenuItem.Text = "&About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "steps";
            // 
            // buttonClearGraphs
            // 
            this.buttonClearGraphs.Location = new System.Drawing.Point(952, 47);
            this.buttonClearGraphs.Name = "buttonClearGraphs";
            this.buttonClearGraphs.Size = new System.Drawing.Size(81, 23);
            this.buttonClearGraphs.TabIndex = 17;
            this.buttonClearGraphs.Text = "Clear Graphs";
            this.buttonClearGraphs.UseVisualStyleBackColor = true;
            this.buttonClearGraphs.Click += new System.EventHandler(this.buttonClearGraphs_Click);
            // 
            // FormPotsModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1215, 578);
            this.Controls.Add(this.buttonClearGraphs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox_PlotX);
            this.Controls.Add(this.pictureBox_PlotMAve);
            this.Controls.Add(this.pictureBox_PlotEAve);
            this.Controls.Add(this.pictureBox_PlotC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar_Latency);
            this.Controls.Add(this.groupBoxPic);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownIt);
            this.Controls.Add(this.labeldata);
            this.Controls.Add(this.pictureBoxSpinSite);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPotsModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pots Model";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPotsModel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpinSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIt)).EndInit();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxPic.ResumeLayout(false);
            this.groupBoxPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Latency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotEAve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotMAve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlotX)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBoxSpinSite;
        private System.Windows.Forms.Label labeldata;
        private System.Windows.Forms.NumericUpDown numericUpDownIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Tend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Tfirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPic;
        private System.Windows.Forms.CheckBox checkBox_ShowSpin;
        private System.Windows.Forms.TrackBar trackBar_Latency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox_PlotC;
        private System.Windows.Forms.PictureBox pictureBox_PlotEAve;
        private System.Windows.Forms.PictureBox pictureBox_PlotMAve;
        private System.Windows.Forms.PictureBox pictureBox_PlotX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_nEqui;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonClearGraphs;
    }
}

