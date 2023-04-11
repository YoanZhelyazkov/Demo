using System;
namespace BasicOopDemo.Async
{
	public class AsyncMethods
	{

		public async Task<string> GetSomeData()
		{
            return await GetSomeData3();
		}

        public async Task GetSomeData2()
        {
            Console.WriteLine("Some print 2");
        }

        public async Task<string> GetSomeData3()
        {
            GetSomeData2().RunSynchronously();
            return "Some print 3";
        }
    }
}

