using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            for (int i = 0; i < nLines; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine()); 

                if(totalQuantity - currentQuantity >= 0)
                {
                    totalQuantity -= currentQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            int totalFilledQuantity = CAPACITY - totalQuantity;
            Console.WriteLine(totalFilledQuantity);
        }
    }
}
