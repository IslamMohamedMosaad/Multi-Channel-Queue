using Business;
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
    public partial class InterarrivalDistribution : Form
    {
        List<Distribution> interarrival_distribution;
        public InterarrivalDistribution(List<Distribution> interarrival_distribution)
        {
            InitializeComponent();
            this.interarrival_distribution = interarrival_distribution;
        }

        private void BtnInterarrivalAdd_Click(object sender, EventArgs e)
        {
            
            int RowsCount=grdInterarrival.RowCount-1;
            for (int i = 0; i < RowsCount; i++)
            {
                Distribution dst = new Distribution();
                dst.Time = int.Parse(grdInterarrival.Rows[i].Cells[0].Value.ToString());
                dst.Probability = double.Parse(grdInterarrival.Rows[i].Cells[1].Value.ToString());
                interarrival_distribution.Add(dst);

            }           
            this.Close();
        }
    }
}
