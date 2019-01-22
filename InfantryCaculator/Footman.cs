using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfantryCalculator
{
    public class Footman
    {
        public double GetNumber()
        {
            Console.Write($"Enter number of footman in your charge:     ");
            int b= int.Parse(Console.ReadLine());
            if (b< 0)
            {
                Console.WriteLine("Invalid number please enter number of footman in your charge");
                b= int.Parse(Console.ReadLine());
            }
            return b * 2.8; 
        }
    }
}
