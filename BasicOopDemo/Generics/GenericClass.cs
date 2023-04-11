using System;
namespace BasicOopDemo.Generics
{
	public class GenericClass <T>
	{
		public void PrintInput<U>(U input)
		{
			Console.WriteLine(input);
		}

		public U GetUserInput<U>(U input)
		{
			return input;
		}
	}
}

