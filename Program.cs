using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, val3, i, n;
            Console.Write("Enter the How Many Times will Run ");
            n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Fibonacci series:");
      Console.Write(val1+" "+val2+" ");
      for(i=2;i<n;++i) {
         val3 = val1 + val2;
         Console.Write(val3+" ");
         val1 = val2;
         val2 = val3;
         Console.ReadLine();
         
      }
   }
        }
    }

