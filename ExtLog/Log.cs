using System;
using SadrTools.ExtensionMethods;
using System.IO;

namespace ExtLog
{
    public static class Log
    {
        public static void Loged(this Exception ex)

        {
            string date = DateTime.Now.ToPersianDate('_');
            using (StreamWriter sw = new StreamWriter(@$"E:\BootCamp\PracticeAtHome\IOPractice\ExLog\LogFolder\{date}.txt"))
            {
                sw.WriteLine("xxxxx");
                sw.WriteLine(ex.ToString());
                sw.WriteLine("xxxxx");
            }
        }
    }
}
