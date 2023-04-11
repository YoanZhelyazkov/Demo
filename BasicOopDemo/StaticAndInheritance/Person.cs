namespace BasicOopDemo;

public abstract class Person
{
    private string? Name { get; set; }
    public int? Age { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetNameFancy(string name) => Name = name; 

    public string GetPersonRepresantation()
    {
        return $"Person name is: {Name} and have an age of: {Age}";
    }

    public string GetPersonRepresantationNew() => $"Person name is: {Name} and have an age of: {Age} the new way";
}