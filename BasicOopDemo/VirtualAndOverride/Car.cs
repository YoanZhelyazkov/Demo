using System;
namespace BasicOopDemo.VirtualAndOverride
{
	public abstract class Car
	{
		public virtual void PrintCharacteristics()
		{
			Console.WriteLine("Print brand");
		}
	}
}

