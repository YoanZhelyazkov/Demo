using System;
namespace BasicOopDemo
{
	public class Car
	{
		public string EngineType { get; set; }

		public Car(string engineType)
		{
			EngineType = engineType;
		}

		public void PrintEngineType()
		{
			Console.WriteLine(EngineType);
		}
	}
}

