using System;

namespace ExecQuestion5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
                Console.WriteLine(args[0] + " " + args[1]);
            else
                Console.WriteLine("ExeTest <string parameter>");
        }
    }
}
