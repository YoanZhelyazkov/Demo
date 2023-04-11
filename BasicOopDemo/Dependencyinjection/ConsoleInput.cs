using System;
namespace BasicOopDemo.Dependencyinjection
{
	public class ConsoleInput : BaseConsoleClass
	{

		public void PrintGreeting()
		{
            var input = ReceiveInputFromConsole();
			PrintOnConsole(input);

            Console.WriteLine("Hey from Input class!");
		}
		
    }
}

