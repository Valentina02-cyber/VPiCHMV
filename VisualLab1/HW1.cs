using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualLab1
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] box_office = new int[n];
            int time = 0;

            if (customers.Length < n)
            {
                n = customers.Length;
            }

            for (int j = 0; j < n; j++)
            {
                box_office[j] = customers[j];
            }

            int i = n;
            while (i < customers.Length)
            {

                int min = box_office[0];
                for (int j = 1; j < n; j++)
                {
                    if (box_office[j] < min)
                    {
                        min = box_office[j];
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    box_office[j] -= min;
                }
                time += min;

                for (int j = 0; j < n; j++)
                {
                    if (box_office[j] == 0 && i < customers.Length)
                    {
                        box_office[j] = customers[i];
                        i++;
                    }
                }
            }

            int max = 0;
            for (int j = 0; j < n; j++)
            {
                if (box_office[j] > max)
                {
                    max = box_office[j];
                }
            }
            return time + max;
        }
    }
}
