using System;
namespace SummatorTests
{
    public class Summator
    {
        public static int Sum(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(new int[] { 10, 20, 30 }));
        }
    }
}
    

