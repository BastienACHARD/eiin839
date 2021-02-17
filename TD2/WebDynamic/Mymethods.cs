using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WebDynamic
{
    class Mymethods
    {
        public Mymethods()
        {

        }

        public string MyMethod(string param1_value, string param2_value)
        {
            return "<HTML><BODY> Hello " + param1_value + " et " + param2_value + "</BODY></HTML>";
        }

        public string ExeCall(string param1_value, string param2_value)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\bastien\Documents\GitHub\eiin839\TD2\ExecQuestion5\bin\Debug\netcoreapp3.1\ExecQuestion5.exe"; // Specify exe name.
            start.Arguments = param1_value + " " + param2_value; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    return result;
                }
            }
        }
    }
}
