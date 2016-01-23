using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Distribution
    {
        public int Time { get; set; }
        public double Probability { get; set; }
        public double CumulativeProbability { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public static int CheckCorresponding(List<Distribution> table,int RandomValue)
        {
            for (int i = 0; i < table.Count; i++)
            {
                if (RandomValue >= table[i].start && RandomValue <= table[i].end)
                    return table[i].Time;
            }
            return -1;
        }
        //check for better performance
        public static int getTimesFactor(List<Distribution> table)
        {
            int max = 0;
            for (int i = 0; i < table.Count - 1; i++)
            {
                string[] tmp = table[i].CumulativeProbability.ToString().Split('.');
                if (tmp[1].Length > max)
                    max = tmp[1].Length;
            }
            int ret = 1;
            for (int i = 0; i < max; i++)
            {
                ret = ret * 10;
            }

            return ret;
        }

        public static List<Distribution> getDistributionTabel(List<Distribution> table)
        {
            ////bdrab 2l arkam kolha fy rakam sabt wala kol wa7ed 3la 7asab 3add 2l digits 2li tl3t fyh y3ny fy 2l slides 2l 3 htdrb fy 10 wala 100
            //int timesFactor = getTimesFactor(table[table.Count-1].CumulativeProbability);//msh s77

            table[0].CumulativeProbability = table[0].Probability;
            //table[0].start = 0;
            //table[0].end = Convert.ToInt32(table[0].CumulativeProbability * timesFactor);

            for (int i = 1; i < table.Count; i++)
            {
                table[i].CumulativeProbability = table[i].Probability + table[i - 1].CumulativeProbability;
                //table[i].start = table[i - 1].end + 1;
                //table[i].end = Convert.ToInt32(table[i].CumulativeProbability * timesFactor);
            }
            int timesFactor = getTimesFactor(table);
            for (int i = 0; i < table.Count; i++)
            {
                if (i == 0)
                {
                    table[0].start = 0;
                    table[0].end = Convert.ToInt32(table[0].CumulativeProbability * timesFactor);
                }
                else
                {
                    table[i].start = table[i - 1].end + 1;
                    table[i].end = Convert.ToInt32(table[i].CumulativeProbability * timesFactor);
                }

            }
                return table;
        }

    }
}
