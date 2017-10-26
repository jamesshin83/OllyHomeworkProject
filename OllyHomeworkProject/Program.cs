using BLL.Model;
using BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OllyHomeworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BLL.Year3.Questions year3Qs = new BLL.Year3.Questions();

            Console.WriteLine("Press any key to proceed...");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine();
                //Console.WriteLine(year3Qs.GenerateQuestion1());
                Console.WriteLine(year3Qs.GenerateQuestion2());
            }
        }
    }
}
