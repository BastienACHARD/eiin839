using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.MathsOperationsClient calc = new ServiceReference1.MathsOperationsClient();
            Console.WriteLine(calc.Add(1, 3));
            Console.ReadLine();
        }
    }
}
