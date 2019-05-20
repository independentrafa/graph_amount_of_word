using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kol = 0;
            char[] a = new char[5];
            a[0] = 'п';
            a[1] = 'е';
            a[2] = 'с';
            a[3] = 'н';
            a[4] = 'я';
            for(int i =0;i<5;i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        for (int m = 0; m < 5; m++)
                        {
                            for (int n = 0; n < 5; n++)
                            {
                                if ((a[i] != a[k]) && (a[i] != a[l]) && (a[i] != a[m]) && (a[i] != a[n])
                                    && (a[k] != a[l]) && (a[k] != a[m]) && (a[k] != a[n])
                                    && (a[l] != a[m]) && (a[l] != a[n])
                                    && (a[m] != a[n]))
                                {
                                    Console.Write(a[i]);
                                    Console.Write(a[k]);
                                    Console.Write(a[l]);
                                    Console.Write(a[m]);
                                    Console.Write(a[n]);
                                    Console.Write("\t");
                                    kol++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Количество слов: " + kol);
            Console.ReadKey();
        }
    }
}
