using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SeverBusyTimeChart : Form
    {
        List<int> BusyTime;
        int systemRunningTime;
        public SeverBusyTimeChart(List<int> BusyTime, int systemRunningTime)
        {
            InitializeComponent();
            this.BusyTime = BusyTime;
            this.systemRunningTime = systemRunningTime;
        }

        private void SeverBusyTimeChart_Load(object sender, EventArgs e)
        {
            chrtServerBusy.ChartAreas[0].AxisX.Maximum = systemRunningTime;
            chrtServerBusy.ChartAreas[0].AxisX.Minimum = 0;
            chrtServerBusy.ChartAreas[0].AxisY.Maximum = 1;
            chrtServerBusy.ChartAreas[0].AxisY.Minimum = 0; 
            for(int i=0;i<BusyTime.Count;i+=2)
            {
                for(int j=BusyTime[i];j<=BusyTime[i+1];j++)
                {
                    chrtServerBusy.Series["Busy"].Points.AddXY(j, 1);
                }

            }
        }
    }
}
