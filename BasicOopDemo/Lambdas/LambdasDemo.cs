using System;
namespace BasicOopDemo.Lambdas
{
	public class LambdasDemo
	{

		public void LambdaMethod()
		{
			var names = new List<string>()
			{ "Pesho", "Gosho" , "Vesko", "Vesko"};

			var filteredResult = names.Where(name => name.Equals("Vesko")).ToList();

			foreach (var name in filteredResult)
			{
				Console.WriteLine(name[1]);
			}
		}

		public void OrdinaryMethod()
		{
			Console.WriteLine("Ordinary method");
		}

		public void FancyMethod() => Console.WriteLine("Fancy method");

		public string OrdinaryReturnString()
		{
			var basicString = "";

			basicString += "45"; // = basicString = basicString + 45

			return basicString;
		}

		public string FancyReturnString() => "";

		public void ItineraryOperator()
		{
			var someString = string.Empty;
			var otherString = "otherString";

			if (otherString == "otherString")
			{
				someString = "someString";
			}
			else
			{
				someString = "thirdOption";
			}
										//Condition
			var fansyStringAssignment = otherString == "otherString" ? // if condition true, then next line will be executed
														"someString" : // if not, the last line will be executed
														"thirdOption";
		}
	}
}

