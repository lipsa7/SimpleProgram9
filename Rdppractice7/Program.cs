using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdppractice7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.LargestInteger(num));

            Console.ReadKey();
        }
    }

    class UserProgramCode
    {
        public static int LargestInteger(int num)
        {
            int[] arr;
            arr = num.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();

            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max <= arr[i])
                {
                    max = arr[i];
                }
            }

            return max;

        }
    }
}
