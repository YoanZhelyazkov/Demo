using System;
namespace BasicOopDemo.VirtualAndOverride
{
	public class FamilyCar : Car
	{

        public override void PrintCharacteristics()
        {
            base.PrintCharacteristics();
            Console.WriteLine("Being practical");
        }
    }
}

