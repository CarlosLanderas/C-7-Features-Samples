using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace C7Features
{
    public class ExpressionBodiedMembers : IRunnable
    {
        public class User
        {
            private string _name;
            public string Name
            {
                get => _name;
                set => _name = value;
            }
            public User(string name) => Name = name;
            ~User() => Console.WriteLine("User instance destroyed");
        }

        public void Run()
        {
            var user =  new User("Peter");
            user = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
