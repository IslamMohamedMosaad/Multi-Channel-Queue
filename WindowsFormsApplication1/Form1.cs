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
    public partial class Form1 : Form
    {
        List<Distribution> interarrival_distribution = new List<Distribution>();
        //List<Tuple<int, int>> wait = new List<Tuple<int, int>>();

        List<Server> LstServer = new List<Server>();
        List<Customer> ResultList;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSelectionMethod.DataSource = Enum.GetValues(typeof(SelectionMethod));
            Server.Occupied = new List<Server>();
            Customer.WaitingQueue = new Queue<Customer>();
        }

        private void btnInterarrivalAdd_Click(object sender, EventArgs e)
        {
            InterarrivalDistribution IDT = new InterarrivalDistribution(interarrival_distribution);
            IDT.Show();
        }
        private void btnAddServer_Click(object sender, EventArgs e)
        {

            ServiceDistribution SDT = new ServiceDistribution(LstServer);
            SDT.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ResultList = new List<Customer>();
            List<Tuple<int, int>> CustomerPerTime = new List<Tuple<int, int>>();
            //calculate distribution tables
            Customer.IntervalTimeDistribution = Distribution.getDistributionTabel(interarrival_distribution);
            for (int i = 0; i < LstServer.Count; i++)
            {
                LstServer[i].ServiceTimeDistribution = Distribution.getDistributionTabel(LstServer[i].ServiceTimeDistribution);



            }
            /*----Get Random Max-----*/
            int ServiceTimeTableLength = LstServer[0].ServiceTimeDistribution.Count;
            int InterArrivalTableLength = Customer.IntervalTimeDistribution.Count;
            int ArrivalRandomMax = Customer.IntervalTimeDistribution[InterArrivalTableLength - 1].end;
            int ServiceTimeRandomMax = LstServer[0].ServiceTimeDistribution[ServiceTimeTableLength - 1].end;
            /*---------------------------------*/
            int numberOfCustomer = int.Parse(txtCustomersCount.Text);
            SelectionMethod SM;
            Enum.TryParse<SelectionMethod>(cmbSelectionMethod.SelectedValue.ToString(), out SM);

            int ServedCustomers = 0;
            int currentTime = 0;

            /*-----------------statistics variables------------------*/
            int totalWaitingTime = 0;
            int WaitedCustomers = 0;
            int MaxQueueLength = 0;
            int MaxWaitingTime = 0;
            /*------------------------------------------------------*/

            Random rand = new Random();
            Server.Available = new List<Server>(LstServer);

            while (numberOfCustomer > ServedCustomers)
            {

                int alreadyInQueue = 0; //flag to check if current customer already in queue;
                Customer currentCustomer = new Customer();

                try
                {

                    //check if there is a customer in queue if yes and there is an available server dequeue customer else start with a new customer
                    if (Customer.WaitingQueue.Count != 0)
                    {
                        currentTime = currentTime + 1;
                        alreadyInQueue = 1;
                        int selectedServer = Server.SelectServer(currentTime, SM);
                        currentCustomer = Customer.WaitingQueue.Dequeue();
                        currentCustomer.SelectedServer = selectedServer;
                        currentCustomer.WaitingTime = currentTime - currentCustomer.ArrivalTime;
                        totalWaitingTime += currentCustomer.WaitingTime;
                        if (currentCustomer.WaitingTime > MaxWaitingTime)
                        {
                            MaxWaitingTime = currentCustomer.WaitingTime;
                        }
                        //wait.Add(new Tuple<int, int>(currentCustomer.ArrivalTime, currentCustomer.ArrivalTime + currentCustomer.WaitingTime));

                    }
                    else
                    {
                        currentCustomer.Number = ServedCustomers + 1;
                        currentCustomer.WaitingTime = 0;
                        if (ServedCustomers == 0)
                        {
                            currentCustomer.ArrivalTime = 0;
                            currentCustomer.RandomDigitsForArrival = null;
                            currentCustomer.InterArrivalTime = null;

                        }
                        else
                        {
                            currentCustomer.RandomDigitsForArrival = rand.Next(0, ArrivalRandomMax);
                            currentCustomer.InterArrivalTime = Distribution.CheckCorresponding(Customer.IntervalTimeDistribution, (int)currentCustomer.RandomDigitsForArrival);
                            currentCustomer.ArrivalTime = ((int)currentCustomer.InterArrivalTime) + ResultList[ServedCustomers - 1].ArrivalTime;

                        }
                        currentTime = currentCustomer.ArrivalTime;
                        currentCustomer.SelectedServer = Server.SelectServer(currentTime, SM);



                    }

                    /*----Get service distribution time of selected server---------*/
                    int OccupiedNumber = Server.Occupied.Count;
                    List<Distribution> service_Time_distribution = Server.Occupied[OccupiedNumber - 1].ServiceTimeDistribution;
                    /*------------------------------------------------------------*/

                    currentCustomer.RandomDigitsForService = rand.Next(0, ServiceTimeRandomMax);
                    currentCustomer.serviceStartTime = currentCustomer.ArrivalTime + currentCustomer.WaitingTime;
                    currentCustomer.ServiceTime = Distribution.CheckCorresponding(service_Time_distribution, currentCustomer.RandomDigitsForService);
                    currentCustomer.DepartureTime = currentCustomer.serviceStartTime + currentCustomer.ServiceTime;


                    /*---Update current server info---*/
                    Server.Occupied[OccupiedNumber - 1].TotalIdleTime += (currentCustomer.serviceStartTime - Server.Occupied[OccupiedNumber - 1].AvailableAt);
                    Server.Occupied[OccupiedNumber - 1].UtilizationTime += currentCustomer.ServiceTime;
                    Server.Occupied[OccupiedNumber - 1].AvailableAt = currentCustomer.DepartureTime;
                    Server.Occupied[OccupiedNumber - 1].BusyTime.Add(currentCustomer.serviceStartTime);
                    Server.Occupied[OccupiedNumber - 1].BusyTime.Add(currentCustomer.DepartureTime);
                    Server.Occupied[OccupiedNumber - 1].ServedCount += 1;
                    /*--------------------------------*/
                    ResultList.Add(currentCustomer);
                    ServedCustomers = ServedCustomers + 1;




                }
                catch
                {
                    if (alreadyInQueue == 0)
                    {
                        Customer.WaitingQueue.Enqueue(currentCustomer);
                        WaitedCustomers = WaitedCustomers + 1;

                        if (Customer.WaitingQueue.Count > MaxQueueLength)
                            MaxQueueLength = Customer.WaitingQueue.Count;

                        CustomerPerTime.Add(new Tuple<int, int>(currentTime, Customer.WaitingQueue.Count));
                    }



                }




            }
            grdResult.DataSource = ResultList;

            int SystemRunningTime = ResultList[ServedCustomers - 1].DepartureTime;

            Server.FreeSevers(SystemRunningTime);
            Dashboard dashboard = new Dashboard(CustomerPerTime, ResultList, MaxWaitingTime);
            dashboard.Show();

            /////////////////////////////////////////////////////////

            //int start = wait[0].Item1;
            //int end = wait[0].Item2;
            //int cur = 0;
            //int maxSoFar = 0;
            //for (int i = 1; i < wait.Count; i++)
            //{
            //    if (wait[i].Item1 <= end)
            //    {
            //        cur += 1;
            //    }
            //}

            ///////////////////////////////////////////////////////////
            //MaxQueueLength = 0;
            //int currentMax = 0;

            //for (int i = 1; i < numberOfCustomer; i++)
            //{
            //    //if (Convert.ToInt32(grdResult.Rows[i].Cells[grdResult.ColumnCount - 1].Value) > 0)
            //    if (ResultList[i].WaitingTime > 0)
            //    {
            //        currentMax = 1;
            //    }

            //    int arr_old = ResultList[i - 1].ArrivalTime;
            //    int dep_old = ResultList[i - 1].WaitingTime + arr_old;

            //    if (ResultList[i].ArrivalTime <= dep_old && Server.Available.Count == 0)
            //    {
            //        currentMax += 1;
            //    }

            //    else
            //    {
            //        currentMax = 0;
            //    }

            //    if (MaxQueueLength < currentMax)
            //    {
            //        MaxQueueLength = currentMax;
            //    }
            //}

            /////////////////////////////////////////////////////////

            StatisticsForm SF = new StatisticsForm(numberOfCustomer, MaxQueueLength, totalWaitingTime, WaitedCustomers, SystemRunningTime, LstServer);
            SF.Show();
        }


    }


}
