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
    public partial class Dashboard : Form
    {
        List<Tuple<int, int>> CustomerPerTime;
        List<Business.Customer> resultList;
        int MaxWaitingTime;
        
        public Dashboard(List<Tuple<int, int>> CustomerPerTime, List<Business.Customer> resultList, int MaxWaitingTime)
        {
            InitializeComponent();
            this.CustomerPerTime = CustomerPerTime;
            this.resultList = resultList;
            this.MaxWaitingTime = MaxWaitingTime;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //waiting chart
            for (int i = 0; i < CustomerPerTime.Count; i++)
            {
                chrtWaitingPerTime.Series["Customer"].Points.AddXY(CustomerPerTime[i].Item1, CustomerPerTime[i].Item2);
            }


            //another one
            int[] WaitingPerMin = new int[MaxWaitingTime + 1];
            for (int i = 0; i < resultList.Count;i++ )
            {
                WaitingPerMin[resultList[i].WaitingTime] += 1;
            }
                for (int i = 0; i < WaitingPerMin.Length; i++)
                {
                    chrtWaitingPerMin.Series["Customer"].Points.AddXY(i, WaitingPerMin[i]);
                }
        }
    }
}
