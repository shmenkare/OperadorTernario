using System;
using System.Collections.Generic;
using System.Text;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame la hora en formato 24 hrs");
            int hora = Convert.ToInt32(Console.ReadLine());
            string time = hora <= 12 ? "AM" : "PM";
            Console.WriteLine(time);
           // Console.ReadKey();

        }
    }
}
