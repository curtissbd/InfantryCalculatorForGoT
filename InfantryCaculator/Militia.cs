using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfantryCalculator
{
   public class Militia
    {
      public double GetNumber()
        {      
            Console.Write($"Enter number of militia in your charge:      ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Invalid number please enter number of Sellswords in your charge");
                a = int.Parse(Console.ReadLine());
            }
            return a * 2;
        }
    }
}
