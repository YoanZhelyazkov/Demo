namespace BasicOopDemo;

public class BasicOopPlayground
{
    public void NonStaticPersonDemo()
    {
        //var personPesho = new Person();
        //personPesho.Name = "Pesho";
        //personPesho.Age = 35;

        //var personGosho = new Person();
        //personGosho.Name = "Gosho";
        //personGosho.Age = 25;

        //var personYoan = new Person
        //{
        //    Name = "Yoan",
        //    Age = 35
        //};

        StaticPerson.Name = "StaticDude";
        StaticPerson.Age = 12;

        StaticPerson.Name = "AnotherStaticDude";
        StaticPerson.Age = 56;
        
        Console.WriteLine(StaticPerson.Name);
        Console.WriteLine(StaticPerson.Age);
    }

    public void InheritanceDemo()
    {
        var Employee = new Employee
        {
            Age = 24,
            Salary = 2500.56
        };

        Employee.SetName("Yordan");

        var Employee2 = new Employee
        {
            Age = 27,
            Salary = 2550.56
        };

        Employee.GetPersonRepresantation();
    }
}