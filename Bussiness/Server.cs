using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public enum SelectionMethod
    {
        Priority,
        UtilizationTime,
        Random
    }

    public class Server
    {
        public Server()
        {
            UtilizationTime = 0;
            AvailableAt = 0;
            TotalIdleTime = 0;
            BusyTime = new List<int>();
            ServedCount = 0;
        }

        public int Number { get; set; }
        public string Agent { get; set; }
        public int UtilizationTime { get; set; }
        public int Priority { get; set; }
        public int AvailableAt { get; set; }
        public int TotalIdleTime { get; set; }
        public List<int> BusyTime { get; set; }
        public int ServedCount { get; set; }

        public static List<Server> Available { get; set; }
        public static List<Server> Occupied { get; set; }

        public List<Distribution> ServiceTimeDistribution { get; set; }
        public static void FreeSevers(int currentTime)
        {
           
              
               for (int i = 0; i <Occupied.Count ;i++)
               {
                   if (Occupied[i].AvailableAt <= currentTime)
                   {
                       Available.Add(Occupied[i]);
                       Occupied.RemoveAt(i);
                       i--;
                   }
               }

        }
        public static int SelectServer(int ArrivalTime,SelectionMethod SelectionMethod = SelectionMethod.Priority)
        {
            FreeSevers(ArrivalTime);
            //priority
            if (SelectionMethod == SelectionMethod.Priority)
            {
                if (Available.Count >= 1)
                {
                    int highest = Available[0].Priority;
                    int index = 0;
                    for (int i = 1; i < Available.Count; i++)
                    {
                        if (Available[i].Priority < highest)
                        {
                            highest = Available[i].Priority;
                            index = i;
                        }
                    }

                    Server tmp = Available[index];
                    Available.RemoveAt(index);
                    Occupied.Add(tmp);
                    return tmp.Number;
                }

                else
                {
                    throw new Exception("busy");
                }
            }

            //Utilization time
            else if (SelectionMethod == SelectionMethod.UtilizationTime)//least utilization keda msh s7!
            {
                if (Available.Count >= 1)
                {
                    int highest = Available[0].UtilizationTime;
                    int index = 0;
                    for (int i = 1; i < Available.Count; i++)
                    {
                        if (Available[i].UtilizationTime < highest)
                        {
                            highest = Available[i].UtilizationTime;
                            index = i;
                        }
                    }

                    Server tmp = Available[index];
                    Available.RemoveAt(index);
                    Occupied.Add(tmp);
                    return tmp.Number;
                }
                else
                {
                    throw new Exception("busy");
                }
            }

             //random
            else
            {
                if (Available.Count >= 1)
                {
                    Random r = new Random();
                    int rnd = r.Next(0, Available.Count);

                    Server tmp = Available[rnd];
                    Available.RemoveAt(rnd);
                    Occupied.Add(tmp);
                    return tmp.Number;
                }
                else
                {
                    throw new Exception("busy");
                }
            }
        }

    }
}
