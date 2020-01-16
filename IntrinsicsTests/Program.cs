using System;

namespace IntrinsicsTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static unsafe public int[] Repeat(int value, int size)
        {
            int vecSize = 256 / 8 / 4;
            int[] array = new int[size];

            fixed (int* ptr = array)
            {
                
            }
            
            
            return new int[size];
        }
    }
}