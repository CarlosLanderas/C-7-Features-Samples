using System;
using System.Collections.Generic;
using System.Text;

namespace C7Features
{
    public class IsPatternMatching: IRunnable

    {
        public void Run()
        {
            var result1 = IsGreaterThanTen("8");
            var result2 = IsGreaterThanTen(123_456_789);
            var result3 = IsGreaterThanTen(0x3D_10);
            var result4 = IsGreaterThanTen("pepe");

            Console.WriteLine("Is greater than ten?");
            Console.WriteLine($" {result1} {result2} {result3} {result4}");
        }

        public bool  IsGreaterThanTen(object value)
        {
            if (value is int i && i > 10 || value is string s && int.TryParse(s, out i) && i > 10)
            {
                return true;
            }

            return false;
        }
        
    }
}
