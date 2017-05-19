using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace C7Features
{
    public class RefReturn: IRunnable
    {
        
        private Lazy<Random> random = new Lazy<Random>(() => new Random(125));
        public async ValueTask<int> GetAsyncNumber(bool isAsync)
        {
            var randomNumber = random.Value.Next(0,100);

            if (isAsync)
            {
                return await Task.Run(() => randomNumber);
            }

            return randomNumber;

        }

        public async void Run()
        {
           var number =  await GetAsyncNumber(false);
           var number2 = await GetAsyncNumber(true);
        }
    }
}
