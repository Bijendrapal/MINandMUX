using System;

namespace MINandMUX
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max, min;
            Console.WriteLine("Enter the Maximum of range ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the input number by user");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Enter the Input number");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if(arr[i]> max)
                {
                    max = arr[i];
                }
            }
            for (int j= 0; j < n; j++)
            {
                if (arr[j]<min)
                {
                    min = arr[j];
                }
            }
            Console.WriteLine("The insert number in a arry max and min,max ={0} min={1}", max, min);
            Console.ReadLine();
        }
    }
}
