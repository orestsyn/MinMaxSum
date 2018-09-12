using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] line = s.Split(' ');
            int[] array = new int[5];
            double result = 0;
            double max = 0;
            double min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(line[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                double res = result;
                res -= array[i];
                if (res > max)
                {
                    max = res;
                }
            }
            min = max;
            for (int i = 0; i < array.Length; i++)
            {
                double res = result;
                res -= array[i];
                if (res < min)
                {
                    min = res;
                }
            }
            Console.WriteLine("{0} {1}", min, max);
            Console.ReadKey();
        }
    }
}
