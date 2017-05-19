using System;
using System.Collections.Generic;
using System.Text;

namespace C7Features
{
    public class OutVariables: IRunnable
    {
        private readonly Dictionary<int, string> People = new Dictionary<int, string>
        {
            {1, "lucas"},
            {2, "Esteban" }
        };

        public void Run()
        {
            People.TryGetValue(1, out string name);
            Console.WriteLine(name);
        }
        
    }
}
