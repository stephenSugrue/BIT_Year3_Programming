using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProgressIndicator_Steve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public delegate void UpdateProgressBars();


        public void UpdateTrackBar()
        {
            trackBar1.Value++;
        }
        public void UpdateProgressBar()
        {
            progressBar1.PerformStep();
        }
        public void UpdateSpinBox()
        {
            numericUpDown1.Value++;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            UpdateProgressBars d = null;

            if (rdoProgressBar.Checked)
            {

                d = new UpdateProgressBars(UpdateProgressBar);
            }
            if (rdoSpinBox.Checked)
            {

                d = new UpdateProgressBars(UpdateSpinBox);
            }
            if (rdoTrackBar.Checked)
            {

                d = new UpdateProgressBars(UpdateTrackBar);
            }
            SlowMethod(d);
           
        }
        public void SlowMethod(UpdateProgressBars d)
        {
            for (int i = 0; i < 10; i++)
            {
              
                d();
                Thread.Sleep(150);
            }
        }
    }
}
