using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Sorting_Desc
{
    class Program
    {
        static void Main(string[] args)
        {
            //input jumlah array
            Console.Write("Masukan banyak elemen Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array_sort = new int[n];

            //input elemen array
            for (int a = 0; a < n; a++)
            {
                Console.Write("Elemen ke-" + (a + 1) + " = ");
                array_sort[a] = Convert.ToInt32(Console.ReadLine());
            }

            //sorting array
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 2; j++)
                {
                    if (array_sort[j] < array_sort[j + 1])
                    {
                        int temp = array_sort[j];
                        array_sort[j] = array_sort[j + 1];
                        array_sort[j + 1] = temp;
                    }
                }
            }
            //output
            Console.WriteLine("");
            Console.WriteLine("\n Diurutkan secara Descending");
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(array_sort[k]);
            }
            Console.ReadKey();
        }
    }
}
