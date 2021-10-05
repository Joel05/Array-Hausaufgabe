using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Hausaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] werte = new int[10];
            for(int i = 0; i < werte.Length; i++)
            {
                werte[i] = i;
                Console.Write(werte[i] + " ");
            };
            Console.WriteLine(" ");

            int[] values = new int[8] { -2, -7, 0, 3, 8, 4, 17, -1 };

            Console.WriteLine("Größter Wert:" + values.Max());
            Console.WriteLine("Kleinster Wert:" + values.Min());
            Console.WriteLine("Summe:" + values.Sum());
            Console.Write("Gerade Zahlen: ");
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    Console.Write(values[i] + " ");
                }
            }
            Console.WriteLine(" ");
            Console.Write("Ungerade Zahlen: ");
            for(int i = 0; i < values.Length; i++)
            {
                if(values[i]%2 != 0)
                {
                    Console.Write(values[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
