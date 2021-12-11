using System;
using System.Collections.Generic;
using System.Linq;
using PromotionalEngine;

namespace PEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Checking through code 
            PromoEngine PrEng = new PromoEngine();
            int total = PrEng.GetCartTotal(4);  // Pass parameter 1 to 4 for each scenario
            Console.WriteLine("TOTAL :  " + total);

        }
    }
}
