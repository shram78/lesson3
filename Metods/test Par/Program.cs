using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            while (!check)
            {
                Console.WriteLine("Введите число");
                check = int.TryParse(Console.ReadLine(), out int Parse);
            }
           

        }
    }
}
