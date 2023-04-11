using System;
namespace BasicOopDemo.Interface
{
	public class DIController
	{
		private ICar _iCar;

		public DIController(ICar iCar)
		{
			_iCar = iCar;
		}

		public string GetCarBrand()
		{
			return _iCar.GetCarBrand();
		}

		public void PrintSpecificBrand()
		{
			_iCar.PrintBrand(GetCarBrand());
		}

		public void PrintEngineSound()
		{
			_iCar.PrintEngineSound();
		}
	}
}

