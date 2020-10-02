using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTImedrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Current time is {0}", DateTime.Now);
            Console.WriteLine("Please choose a number");
            int X = Convert.ToInt32(Console.ReadLine());
            var Y = DateTime.Now.AddHours(X);
            Console.WriteLine("in {0} hours it will be {1} " , X ,  Y);
            Console.ReadLine();

        }
    }
}
