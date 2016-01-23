using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public virtual Store Store { get; set; }
namespace Business
{
    public class Customer
    {
        
        public int Number { get; set; }
        public int? RandomDigitsForArrival { get; set; }
        public int? InterArrivalTime { get; set; }
        public int ArrivalTime { get; set; }
        public int SelectedServer { get; set; }
        public int RandomDigitsForService { get; set; }
        public int serviceStartTime { get; set; }
        public int ServiceTime { get; set; }
        public int DepartureTime { get; set; }
        public int WaitingTime { get; set; }
        

        public static Queue<Customer> WaitingQueue { get; set; }
        public static List<Distribution> IntervalTimeDistribution { get; set; }
        
        

    }


}
