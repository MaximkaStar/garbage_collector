using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.GC;

namespace garbage_collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Item peace = new Item();
            GC.Collect(0, GCCollectionMode.Forced);
        }
    }
}
