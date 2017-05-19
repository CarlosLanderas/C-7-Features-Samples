using System;
using System.Collections.Generic;
using System.Text;

namespace C7Features
{
    public class LocalFunctions: IRunnable
    {
        public void Run()
        {
            ShowWelcome("Antonio");
        }

        public void ShowWelcome(string name)
        {
            PrintMessage(name);

            void PrintMessage(string message)
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }
}
