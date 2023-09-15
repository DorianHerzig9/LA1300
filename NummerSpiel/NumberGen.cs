using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummerSpiel
{
    internal class NumberGen
    {
        public int number;
        public int min = 1;
        public int max = 100;
        public void Generate()
        {
            number = new Random().Next(min, max);
        }
    }
}
