using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
namespace WindowsFormsApplication1
{
    public partial class StatisticsForm : Form
    {
        int MaxQueueLength;
        int totalWaitingTime;
        int WaitedCustomers;
        int systemRunningTime;
        int numberOfcustomers;
        List<Server> LstServer;
        public StatisticsForm(int numberOfcustomers,int MaxQueueLength, int totalWaitingTime, int WaitedCustomers, int systemRunningTime,List<Server> LstServer)
        {
            InitializeComponent();
            this.MaxQueueLength = MaxQueueLength;
            this.totalWaitingTime = totalWaitingTime;
            this.WaitedCustomers = WaitedCustomers;
            this.systemRunningTime = systemRunningTime;
            this.numberOfcustomers = numberOfcustomers;
            this.LstServer = LstServer;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            double avgWaitingTime =(double) totalWaitingTime / numberOfcustomers;
            double ProbWaiting = (double) WaitedCustomers / numberOfcustomers;
            for (int i = 0; i < LstServer.Count; i++)
            {
                double serverEfficincy = (double)LstServer[i].UtilizationTime / systemRunningTime;
                double AvgServiceTime = (double)LstServer[i].UtilizationTime / LstServer[i].ServedCount;
                //Handle if sever has been idle all time
                if (LstServer[i].TotalIdleTime == 0 && LstServer[i].AvailableAt == 0)
                {
                    LstServer[i].TotalIdleTime = systemRunningTime;
                }
                LstServer[i].TotalIdleTime += (systemRunningTime - LstServer[i].AvailableAt);
                double ProbOfIdle = (double)LstServer[i].TotalIdleTime / systemRunningTime;
                grdServerStatistics.Rows.Add(LstServer[i].Number, serverEfficincy, AvgServiceTime, ProbOfIdle, LstServer[i].TotalIdleTime);
                SeverBusyTimeChart SBTC = new SeverBusyTimeChart(LstServer[i].BusyTime,systemRunningTime);
                SBTC.Text = "Server's " + i + " Busy time chart"; 
                SBTC.Show();
            }
            txtProbCustWait.Text = ProbWaiting.ToString();
            txtAvgWaitingTime.Text = avgWaitingTime.ToString();
            TxtMaxQueueLength.Text = MaxQueueLength.ToString();

        }

    }
}
