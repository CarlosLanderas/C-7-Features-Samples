using System;
using System.Collections.Generic;
using System.Text;

namespace C7Features
{
    public class Tuples : IRunnable
    {
        public void Run()
        {
            var result = SumNumbers(5, 20, 100);
            Console.WriteLine($"Result is {result.sum} with a total of {result.total} numbers");

            //Deconstruction
            var (suma, total) = SumNumbers(2, 20, 4, 100);
            Console.WriteLine($"Result is {suma}");
            
        }

        public (int sum, int total) SumNumbers(params int[] numbers)
        {
            var sum = 0;
            var total = 0;

            foreach (int num in numbers)
            {
                sum += num;
                total += 1;
            }

            return (sum, total);
        }
    }
}
