using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUi
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerIslem.Start(); 
        }

        private void timerIslem_Tick(object sender, EventArgs e)
        {
            float fCPU = performanceCounterCPU.NextValue(); 
            float fRAM = performanceCounterRAM.NextValue();

            metroProgressBarCPU.Value = (int)fCPU;
            metroProgressBarRAM.Value = (int)fRAM;

            metroLabelCPU.Text = string.Format("{0:0.00}%",fCPU);
            metroLabelRAM.Text = string.Format("{0:0.00}%", fRAM);

            chartBilgisayar.Series["CPU"].Points.AddY(fCPU);
            chartBilgisayar.Series["RAM"].Points.AddY(fRAM);
        }
    }
}
