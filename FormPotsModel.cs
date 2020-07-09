using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Pots_Model
{
    public partial class FormPotsModel : Form
    {
        #region New Fields

        public Pots pots;
        Bitmap spinsMap;
        public int L;
        int mcs, q, n_equilib;
        double Tfirst, Tend, dT, T;
        int rectSize;
        Plot plotCurveC, plotCurveX, plotCurveE_Ave, plotCurveM_Ave;

        Rectangle rectPlotCurves;

        Pen penLine = new Pen(Color.Blue);
        Pen penAxes = new Pen(Color.FromArgb(192, 192, 255));
        Pen penRects = new Pen(Color.Red);
        double maxC, TC;

        bool canShowPic;
        FormProgress formProgress;
        int latency;
       
        //const indexer 
        Color[] colorArray = {Color.Gray,  Color.SkyBlue, Color.GreenYellow, Color.Violet, Color.Yellow, Color.Silver,Color.Brown, Color.Red, Color.Orange,
         Color.Green,Color.Black, Color.Blue, Color.DarkBlue, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOrange, Color.DarkRed,Color.Tomato};
        Color[] spinColor;

        Thread threadSimPotsSteps;

        #endregion
        



        #region Initialze System
   
        
        void Reset()
        {
            this.AcceptButton = buttonStart;
            canShowPic = false;
            buttonStart.Text = "Start";
            buttonStart.Enabled = true;
           

            try
            {
                L = int.Parse(textBox_L.Text);
                mcs = int.Parse(textBox_MCS.Text);
                n_equilib = int.Parse(textBox_nEqui.Text);
                q = int.Parse(textBox_q.Text);
                Tfirst = double.Parse(textBox_Tfirst.Text);
                Tend = double.Parse(textBox_Tend.Text);
                dT = double.Parse(textBox_dT.Text);
                if (Tfirst > Tend) dT = -dT;
                T = Tfirst;
   
            }
            catch(FormatException fe)
            {
                buttonStart.Enabled = false;
                MessageBox.Show(fe.ToString());
                return;
            }
            CreateSpinsColor();


            formProgress = new FormProgress("Initialize " + L + "*" + L + " spins. " + "(" + n_equilib + " MonteCarlo steps)");
            Thread threadResetLoading = new Thread(new ThreadStart(DoInitialzePots));  // thread for ising
            threadResetLoading.Start();
            formProgress.ShowDialog();

            if (formProgress.IsFinishedWork)
            {
                canShowPic = true;
                DoAftherInitalizeSpin();
                
            }
            else // the reste loading is not completed and is interupt by user
            {
                threadResetLoading.Abort();
                canShowPic = false;
            }
           

        }
        void DoInitialzePots()
        {
            while (!formProgress.IsHandleCreated)  ;
            pots = new Pots(L, q, mcs, n_equilib);
            pots.InitializeSimulation(T, formProgress);
            formProgress.BeginInvoke((ThreadStart)delegate
                {
                    formProgress.IsFinishedWork = true;
                });
            
        }

        void InitilazePicBoxes()
        {
            if (L <= 16) rectSize = 16;
            else if (L <= 32) rectSize = 12;
            else if (L <= 64) rectSize = 8;
            else rectSize = 1;
            pictureBoxSpinSite.Size = new Size(L * rectSize, L * rectSize);

            groupBoxCondition.Left = pictureBoxSpinSite.Right + 20;
            groupBoxPic.Left = groupBoxCondition.Left;
            groupBoxPic.Top = groupBoxCondition.Bottom + 10;
            labeldata.Left = groupBoxCondition.Left;
            labeldata.Top = groupBoxPic.Bottom + 10;
            pictureBox_PlotC.Left = groupBoxCondition.Right + 40;
            pictureBox_PlotX.Left = pictureBox_PlotC.Right + 25;
            pictureBox_PlotEAve.Left = pictureBox_PlotC.Left;
            pictureBox_PlotMAve.Left = pictureBox_PlotX.Left;

            rectPlotCurves = new Rectangle(50, 30, pictureBox_PlotC.Width - 60, pictureBox_PlotC.Height - 40);
            plotCurveC = new Plot(rectPlotCurves);
            plotCurveX = new Plot(rectPlotCurves);
            plotCurveE_Ave = new Plot(rectPlotCurves);
            plotCurveM_Ave = new Plot(rectPlotCurves);


            spinsMap = new Bitmap(pictureBoxSpinSite.Width, pictureBoxSpinSite.Height);
        }

        public void DoAftherInitalizeSpin()
        {
            InitilazePicBoxes();
            ShowData();
            if (checkBox_ShowSpin.Checked)
                RedrawSpinsBitmap();

            maxC = double.MinValue;
            TC = 0;

            GC.Collect();
        }



        void DoIsingSimulation()
        {
            for (; (dT > 0 && T <= Tend) || (dT < 0 && T >= Tend); T += dT)
            {
                pots.InitializeSimulation(T, false);
                int counterE = 0;
                while (counterE <= mcs)
                {
                    int value = 1, timer = latency;
                    this.Invoke((ThreadStart)delegate
                        {
                            value = (int)numericUpDownIt.Value;
                            //timer = CalculateTimerSleep();
                        });

                    Thread.Sleep(timer);
                    for (int i = 0; i < value && counterE <= mcs; i++)
                    {
                        pots.DoOneMonteCarloStep();
                        counterE++;
                    }
                    this.BeginInvoke((ThreadStart)delegate
                       {
                           DoAftherMCStep();
                       });

                }//
                pots.CalculateAverageParameters(); //  evaluate C , X for Current T
                if (pots.C > maxC)
                {
                    maxC = pots.C;
                    TC = T;
                }
                this.BeginInvoke((ThreadStart)delegate
                         {
                             UpdatePlotClasses();  // plot new points(C, X, ...) in picture boxes
                         });


            }// End for T
            //canShowData = true;

            this.BeginInvoke((ThreadStart)delegate
                    {
                        buttonStart.Enabled = false;
                        MessageBox.Show("Reached to end of temperature !" + "\r\n" + "The TC = " + TC + " (J/K)");
                    });


        }

        void DoAftherMCStep()
        {
            ShowData();
            if (checkBox_ShowSpin.Checked)
            {
                RedrawSpinsBitmap();
                pictureBoxSpinSite.Invalidate();
            }
        }


        #endregion




        #region Other Methods
        void RedrawSpinsBitmap()
        {
            int spin;
            if (rectSize > 1)
            {
                Graphics g = Graphics.FromImage(spinsMap);
                g.Clear(pictureBoxSpinSite.BackColor);
                for (int i = 0; i < L; i++)
                    for (int j = 0; j < L; j++)
                    {
                        spin = pots.spin[i, j];
                        if ( spin > 0)
                        {
                            SolidBrush solid = new SolidBrush(spinColor[spin]);
                            g.FillRectangle(solid, new Rectangle(i * rectSize, j * rectSize, rectSize, rectSize));
                            solid.Dispose();
                        }
                    }
                g.Dispose();
            }
            else
            {
                spinsMap = new Bitmap(L, L);
                for (int i = 0; i < L; i++)
                    for (int j = 0; j < L; j++)
                    {
                        spin = pots.spin[i, j];
                        if (spin > 0)
                            spinsMap.SetPixel(i, j, spinColor[spin]);
                    }
            }

            //GC.Collect();
        }

        void CreateSpinsColor()
        {
            if (q > colorArray.Length)
            {
                spinColor = new Color[q];
                spinColor[0] = colorArray[0];
                for (int i = 1; i < q; i++)
                {
                    Random rand = new Random(i * 100);
                    spinColor[i] = Color.FromArgb(rand.Next(0, 250), rand.Next(0, 250), rand.Next(0, 250));
                }
            }
            else
            {
                int length = colorArray.Length;
                spinColor = new Color[length];
                for (int i = 0; i < length; i++)
                {
                    spinColor[i] = colorArray[i];
                }

            }
        }


        void ShowData()
        {
            int steps = pots.n_countingE;
            double E_ave = (pots.data[0] * mcs) / steps;    // per spin
            double E2_ave = (pots.data[1] * mcs) / steps;
            double M_ave = (pots.data[2] * mcs) / steps;
            double M2_ave = (pots.data[3] * mcs) / steps;

            string st = "steps =  " + steps;
            st += "\r\n" + "  T   = " + T.ToString("f3");
            st += "\r\n" + " <E>  = " + E_ave.ToString("f4");
            st += "\r\n" + " <E2> = " + E2_ave.ToString("f3");
            st += "\r\n" + " <M>  = " + M_ave.ToString("f4");
            st += "\r\n" + " <M2> = " + M2_ave.ToString("f3");
            labeldata.Text = st;
        }

        void ResetTextBoxes()
        {
            textBox_L.Text = "32";
            textBox_MCS.Text = "50000";
            textBox_nEqui.Text = "10000";
            textBox_q.Text = "3";
            textBox_Tfirst.Text = "1.8";
            textBox_Tend.Text = "0.8";
            textBox_dT.Text = "0.05";
        }

        int CalculateTimerInterval()
        {
            int maxInterval = 600, minInterval = 0,
                min = trackBar_Latency.Minimum, max = trackBar_Latency.Maximum, value = trackBar_Latency.Value;

            if (value == max) return 0;
            else if (value == max - 1) return 1;
            else if (value == max - 2) return 10;

            else
                return ((minInterval - maxInterval) * (value - min)) / (max - min) + maxInterval;
        }


        void UpdatePlotClasses()
        {   
            plotCurveE_Ave.AddPoint(T, pots.E_ave);
            plotCurveM_Ave.AddPoint(T, pots.M_ave);
            plotCurveC.AddPoint(T, pots.C);
            plotCurveX.AddPoint(T, pots.X);

            InvalidatePlotPictureBoxes();
            
        }

        void InvalidatePlotPictureBoxes()
        {
            pictureBox_PlotC.Invalidate();
            pictureBox_PlotX.Invalidate();
            pictureBox_PlotEAve.Invalidate();
            pictureBox_PlotMAve.Invalidate();
        }

        #endregion


    
        //-----------------------------------------------------------------------------------------------------

        #region Constructor Form
        public FormPotsModel()
        {
            InitializeComponent();
            ResizeRedraw = true;
            latency =  CalculateTimerInterval();
            ResetTextBoxes();
            Reset();
        }
        #endregion

        #region Button Clicks Methods
        private void buttonClearGraphs_Click(object sender, EventArgs e)
        {
            if (plotCurveC.arrX.Count == 0)
                return;
            plotCurveE_Ave.Reset();
            plotCurveM_Ave.Reset();
            plotCurveC.Reset();
            plotCurveX.Reset();
            UpdatePlotClasses();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string text = buttonStart.Text;

            if (text == "Start")
            {
                threadSimPotsSteps = new Thread(new ThreadStart(DoIsingSimulation));
                threadSimPotsSteps.Start();
                buttonStart.Text = "Pause";
            }
            else if (text == "Pause")
            {
                threadSimPotsSteps.Suspend();
                buttonStart.Text = "Continue";
            }
            else if (text == "Continue")
            {
                threadSimPotsSteps.Resume();
                buttonStart.Text = "Pause";
            }
        }



        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (threadSimPotsSteps != null)
            {
                if (threadSimPotsSteps.ThreadState == ThreadState.Suspended)
                    threadSimPotsSteps.Resume();
                threadSimPotsSteps.Abort();
            }
            Reset();
            if (checkBox_ShowSpin.Checked)
                pictureBoxSpinSite.Invalidate();

            InvalidatePlotPictureBoxes();
        }

        #endregion


        #region PictureBoxes Plot
        private void pictureBoxSpinSite_Paint(object sender, PaintEventArgs e)
        {
            if (!canShowPic)
                return;
            if (!checkBox_ShowSpin.Checked)
                return;

            Graphics g = e.Graphics;
            g.DrawImage(spinsMap, 0, 0);

        }

        private void pictureBox_PlotC_Paint(object sender, PaintEventArgs e)
        {
            if (!canShowPic)
                return;
            Graphics g = e.Graphics;
            g.TranslateTransform(0, pictureBox_PlotC.Height);
            g.ScaleTransform(1, -1);
            plotCurveC.DrawAxes(g, penAxes, "T", "C", 7);
            plotCurveC.DrawLines(g, penLine, penRects);
            

        }

        private void pictureBox_PlotX_Paint(object sender, PaintEventArgs e)
        {
            if (!canShowPic)
                return;
            Graphics g = e.Graphics;
            g.TranslateTransform(0, pictureBox_PlotX.Height);
            g.ScaleTransform(1, -1);
            plotCurveX.DrawAxes(g, penAxes, "T", "X", 7);
            plotCurveX.DrawLines(g, penLine, penRects);
        }

        private void pictureBox_PlotEAve_Paint(object sender, PaintEventArgs e)
        {
            if (!canShowPic)
                return;
            Graphics g = e.Graphics;
            g.TranslateTransform(0, pictureBox_PlotEAve.Height);
            g.ScaleTransform(1, -1);
            plotCurveE_Ave.DrawAxes(g, penAxes, "T", "<E>", 7);
            plotCurveE_Ave.DrawLines(g, penLine, penRects);
        }

        private void pictureBox_PlotMAve_Paint(object sender, PaintEventArgs e)
        {
            if (!canShowPic)
                return;
            Graphics g = e.Graphics;
            g.TranslateTransform(0, pictureBox_PlotMAve.Height);
            g.ScaleTransform(1, -1);
            plotCurveM_Ave.DrawAxes(g, penAxes, "T", "<M>", 7);
            plotCurveM_Ave.DrawLines(g, penLine, penRects);
        }

        #endregion





        #region NotImporatnt

        private void trackBarLatency_ValueChanged(object sender, EventArgs e)
        {
            latency = CalculateTimerInterval();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Designed by Hor Dashti (h.dashti2@gmail.com)";
            MessageBox.Show(text, "About");
        }

        private void FormPotsModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            penAxes.Dispose(); penLine.Dispose(); penRects.Dispose();
            if (threadSimPotsSteps != null)
            {
                if (threadSimPotsSteps.ThreadState == ThreadState.Suspended)
                    threadSimPotsSteps.Resume();
                threadSimPotsSteps.Abort();
            }
        }
        private void groupBoxCondition_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = buttonReset;
        }

        #endregion

       
       






    }
}