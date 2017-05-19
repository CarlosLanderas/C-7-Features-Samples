using System;
using System.Collections.Generic;
using System.Text;

namespace C7Features
{
    public class ThrowExpressions: IRunnable
    {
        public void Run()
        {
            var result = ExecuteAction(() => "This is the action result");
           // ExecuteAction(null);
        }

        public string ExecuteAction(Func<string> action)
        {
            return action?.Invoke() ?? throw new Exception("Action is not defined!");
        }
    }
}
