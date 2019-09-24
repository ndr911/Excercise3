using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] numbers = new int[500];
            Random random = new Random();

            for (int x = 0; x < 500; x++)
            {
                int randomNumber = random.Next(0,1000);
                numbers[x] = randomNumber;
            }


            Console.Write("Random Numers: ");
            for (int i = 0; i < 500; i++)
            {
                Console.Write("{0}  ", numbers[i]);
            }
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("\n");

            Console.WriteLine("Enter a number to find nth smallest");
            int N = Convert.ToInt32(Console.ReadLine());

            FindSmallest(numbers,N);

            System.Threading.Thread.Sleep(5000);

        }

        public static void FindSmallest(int[] arr, int N)
        {
            Array.Sort(arr);
            int nthSmall = arr[N - 1];
            Console.WriteLine($"The int: {nthSmall} is {N} Smallest Value:");
        }


    }

}
