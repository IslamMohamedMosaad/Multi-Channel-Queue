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
    public partial class ServiceDistribution : Form
    {
        List<Server> LstServer;
        public ServiceDistribution(List<Server> LstServer)
        {
            InitializeComponent();
            this.LstServer = LstServer;
        }

        private void BtnServiceAdd_Click(object sender, EventArgs e)
        {
            Server TmpServer = new Server();
            TmpServer.ServiceTimeDistribution = new List<Distribution>();
            int RowsCount = grdServiceDistribution.RowCount - 1;
            for (int i = 0; i < RowsCount; i++)
            {
                
                Distribution dst = new Distribution();
                dst.Time = int.Parse(grdServiceDistribution.Rows[i].Cells[0].Value.ToString());
                dst.Probability = double.Parse(grdServiceDistribution.Rows[i].Cells[1].Value.ToString());
                TmpServer.ServiceTimeDistribution.Add(dst);
                
            }
            TmpServer.Priority = LstServer.Count + 1;
            TmpServer.Number = LstServer.Count + 1;
            LstServer.Add(TmpServer);
            this.Close();
        }

        private void ServiceDistribution_Load(object sender, EventArgs e)
        {
            label1.Text = "Service distribution table of server " + (LstServer.Count + 1);
        }

        
    }
}
