using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int response = 1;
            int answer = 1;
            Console.WriteLine("Please enter a number....");
            response =Int32.Parse(Console.ReadLine());

            for (var i = response; i >= 1; i--){
                answer *= i;
            }
            response = answer;
            Console.WriteLine("Iterative Result: {0}", response);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
