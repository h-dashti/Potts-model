using System;
using System.Windows.Forms;

namespace Pots_Model
{
    public partial class FormProgress : Form
    {
        
        private bool isFinishedWork ;
        public FormProgress(string textIntro)
        {
            InitializeComponent();
            isFinishedWork = false;
            labelIntro.Text = textIntro;
           
           
        }
        public void DoingLoad(double relativeProgress)
        {

            int percent = (int)(relativeProgress * progressBar1.Maximum);
            progressBar1.Value = percent;


        }

        private void FormProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        public bool IsFinishedWork
        {
            get { return isFinishedWork; }
            set 
            {
                isFinishedWork = value;
                this.Close();
                
            }
        }
    }
}