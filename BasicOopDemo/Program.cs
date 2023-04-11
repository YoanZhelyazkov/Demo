
using BasicOopDemo;
using BasicOopDemo.Overload;
using BasicOopDemo.Lambdas;
using BasicOopDemo.Dependencyinjection;
using BasicOopDemo.Interface;
using BasicOopDemo.Generics;
using BasicOopDemo.Async;


//var nonStaticClass = new BasicOopPlayground();

//nonStaticClass.NonStaticPersonDemo();

//var carConstructor = new Car("Diesel");
//carConstructor.PrintEngineType();

//var derivedConstructor = new Van("Gasoline");

//var baseClass = new BasicOopDemo.VirtualAndOverride.Car();
//baseClass.PrintCharacteristics();

//var classWithOverridenMethod = new SportsCar();
//classWithOverridenMethod.PrintCharacteristics();

//var classWithOverridenMethod2 = new FamilyCar();
//classWithOverridenMethod2.PrintCharacteristics();

//var overloadDemo = new OverloadDemo();
//overloadDemo.PrintColour();
//overloadDemo.PrintColour("Red");
//overloadDemo.PrintColour("Blue", "Colour is:");
//overloadDemo.PrintColour("Blue", 15);

//var lambdasDemo = new LambdasDemo();

//lambdasDemo.LambdaMethod();

//var gosho = new Gosho();
//gosho.Speak();
//gosho.SpeakFromInput("Some input from Gosho");
//var input = gosho.ReturnInput();
//Console.WriteLine(input);

//var pesho = new Pesho();
//pesho.Speak();
//pesho.SpeakFromInput("Some input from Pesho");

//var ford = new DIController(new Ford("Ford"));
//ford.PrintSpecificBrand();
//ford.PrintEngineSound();

//var opel = new DIController(new Opel("Opel"));
//opel.PrintSpecificBrand();
//opel.PrintEngineSound();

//var genericClass = new GenericClass<string>();
//genericClass.PrintInput<string>("SomeString");
//genericClass.PrintInput<int>(20);

//Console.WriteLine($"User input is {genericClass.GetUserInput(false)}");

var asyncMethods = new AsyncMethods();
asyncMethods.GetSomeData();
asyncMethods.GetSomeData2();
asyncMethods.GetSomeData3();
