using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfantryCalculator
{
  public  class ManAtArms
    {
       public double GetNumber()
        {
            Console.Write($"Enter number of Man at arms in your charge:      ");
            int d = int.Parse(Console.ReadLine());           
            if (d < 0)
            {
                Console.WriteLine("Invalid number please enter number of Man at arms in your charge");
                d = int.Parse(Console.ReadLine());
            }
            return d * 5;
        }
    }
}
