using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in numbers)
            {
                Console.WriteLine("The number is(shortcut for foreach) = " + i);
            }
        }
    }
}
