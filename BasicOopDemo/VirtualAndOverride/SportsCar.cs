using System;
namespace BasicOopDemo.VirtualAndOverride
{
	public class SportsCar : Car
	{

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();
            Console.WriteLine("Being fast");
        }
    }
}

