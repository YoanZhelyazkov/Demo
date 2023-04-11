using System;
namespace BasicOopDemo.Overload
{
	public class OverloadDemo
	{

		public void PrintColour()
		{
			Console.WriteLine("Print without params");
		}

        public void PrintColour(string colour)
        {
			Console.WriteLine($"Print colour from param{colour}");
        }

        public void PrintColour(string colour, string message)
        {
            Console.WriteLine($"{message}{colour}");
        }

        public void PrintColour(string colour, int message)
        {
            Console.WriteLine($"{message}{colour}");
        }
    }
}

