using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfantryCaculator
{
   public class Axeman
    {
      public double GetNumber()
        {
            Console.Write($"Enter number of Axeman in your charge:       ");
            int e =int.Parse(Console.ReadLine());     
            if (e < 0)
            {
                Console.WriteLine("Invalid number please enter number of Axeman in your charge");
                e = int.Parse(Console.ReadLine());
            }
            return e *6.4;
        }
    }
}
