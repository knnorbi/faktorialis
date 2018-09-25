using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorialis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int n = int.Parse(Console.ReadLine());
            
            int faktor = 1;
            for (int i = 1; i <= n; i++)
                faktor *= i;

            Console.WriteLine(n + "!=" + faktor);

            Console.ReadKey();
        }
    }
}
