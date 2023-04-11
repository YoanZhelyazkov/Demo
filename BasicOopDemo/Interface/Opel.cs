using System;
namespace BasicOopDemo.Interface
{
    public class Opel : ICar
    {
        private string _carBrand;

        public Opel(string carBrand)
        {
            _carBrand = carBrand;
        }

        public void PrintBrand(string brand)
        {
            Console.WriteLine(_carBrand);
        }

        public void PrintEngineSound()
        {
            Console.WriteLine("Silence...");
        }

        public string GetCarBrand()
        {
            return _carBrand;
        }
    }
}

