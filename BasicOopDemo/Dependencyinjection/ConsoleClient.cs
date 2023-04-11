using System;
namespace BasicOopDemo.Dependencyinjection
{
	public class ConsoleClient
	{
		private ConsoleInput _consoleInput;
		private ConsoleOutput _consoleOutput;

		public ConsoleClient(ConsoleInput consoleInput, ConsoleOutput consoleOutput)
		{
			_consoleInput = consoleInput;
			_consoleOutput = consoleOutput;
		}

		public void UseConsole()
		{
			var input = _consoleInput.ReceiveInputFromConsole();

			_consoleOutput.PrintOnConsole(input);
		}
	}
}

