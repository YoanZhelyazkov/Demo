using System;
namespace BasicOopDemo.Interface
{
	public class Ford : ICar
	{
        private string _carBrand;

        public Ford(string carBrand)
        {
            _carBrand = carBrand;
        }

        public void PrintBrand(string brand)
        {
            Console.WriteLine($"The car brand is {_carBrand}");
        }

        public void PrintEngineSound()
		{
			Console.WriteLine("TRtrtrtr");
		}

        public string GetCarBrand()
        {
            return _carBrand;
        }
    }
}

