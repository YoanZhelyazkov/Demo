using System;
namespace BasicOopDemo.Dependencyinjection
{
	public class BaseConsoleClass
	{
        public string ReceiveInputFromConsole()
        {
            return Console.ReadLine();
        }

        public void PrintOnConsole(string input)
        {
            Console.WriteLine(input);
        }
    }
}

