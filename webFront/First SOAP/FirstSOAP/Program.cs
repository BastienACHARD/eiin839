using System;

namespace FirstSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculatorSoapClient calc = new Calculator.CalculatorSoapClient();
            Console.WriteLine(calc.AddAsync(1, 3));
        }
    }
}
