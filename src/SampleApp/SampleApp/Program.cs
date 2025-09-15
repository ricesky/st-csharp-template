using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            var result = c.Add(1, 2);

            Console.WriteLine(result);
        }
    }
}
