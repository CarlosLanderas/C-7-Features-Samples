using System;
using System.Linq;
using System.Reflection;

namespace C7Features
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteRunnables();
            Console.ReadKey();
        }

        private static void ExecuteRunnables()
        {
            var runnables = (from type in typeof(Program).GetTypeInfo().Assembly.GetTypes()
                            let typeInfo = type.GetTypeInfo()
                            where typeInfo.IsClass && typeof(IRunnable).IsAssignableFrom(type)
                            select type).ToList();
            

            for (int i = 0; i < runnables.Count(); i++)
            {
                var runnable = Activator.CreateInstance(runnables[i]) as IRunnable;
                Console.WriteLine($"--------Example: {runnables[i].Name} ----------");
                runnable.Run();
            }
        }
    }
}