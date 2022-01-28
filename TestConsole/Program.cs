using System;
using System.Collections.Generic;
using ExtLog;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> se = new List<string>();
                se.Add("Ali");
                se.Add("Rasool");
                se.Add("Khashayar");
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(se[i]);
                }
            }
            catch (Exception e)
            {

                e.Loged();
            }
        }
    }
}
