using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CoolFunctions
    {
        public int iterfactorial(int n)
        {
            int response = 1;
            int answer = 1;
            Console.WriteLine("Please enter a number....");
            response = Int32.Parse(Console.ReadLine());

            for (var i = n; i >= 1; i--)
            {
                answer *= i;
            }
            response =
            response = answer;

        }

        public static int[] InsertionSort(int[] inputs)
        {
            //step 1: iterate
            var answer = new int[inputs.Length];
            for( var i = 0; i < inputs.Length; i++)
            {

            }
            return answer;
        }
    }
}
