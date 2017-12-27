using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.GC;
using static System.Console;

namespace garbage_collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Item peace = new Item()
            {
                Name = "iPhone",
                Description = "White, 16GB",
            };
            
            WriteLine("Generation of peace: {0}", GC.GetGeneration(peace));
            ReadLine();
            GC.Collect();
            WriteLine("Generation of peace : {0}", GC.GetGeneration(peace));


            ReadLine();
            Clear();
        }
    }
}
