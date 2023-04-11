using System;
namespace BasicOopDemo
{
    public class Van : Car
    {
        public Van(string engineType) : base(engineType)
        {
            Console.WriteLine(engineType);
        }
    }
}

