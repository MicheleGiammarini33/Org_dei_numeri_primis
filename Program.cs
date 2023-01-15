using System;
using System.Linq;
using System.Collections.Generic;

namespace Orgia_dei_numeri_Primis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> Primi_num_fra1 = new List<double>();
            List<double> Primi_num = new List<double>();
            List<double> Div_num = new List<double>();

            double[] t = new double[1000];
            double[] b = new double[1000];

            int o;
            int j = 0;
            for (o = 0; o < 1000; o++, j++)
            {
                { t[o] = j; }
            }

            foreach (double element in t)
            {

                int[] y = new int[1000];

                for (int i = 2; i <= Math.Sqrt(element); ++i)
                {
                    if (element % i == 0)
                    {
                    }
                    else { Primi_num.Insert(0, element); }
                }

                {
                    foreach (double qq in Primi_num)
                    {
                    Div_num.Insert(0, qq);
                    }
                    if (Div_num.Count > 1000) 
                         {
                            int f;
                            int r = 0;
                            for (f = 0; f < 1000; f++, r++)
                            {double g = Div_num[f];
                         
                             double s = 1 / g;
                            Primi_num_fra1.Insert(0, s);   
                        }
                        double er = Primi_num_fra1.Sum();
                        Console.WriteLine(er);
                    }   
                }
            }
        }
    }
}
  



