using System;

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person(string? name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age : " + Age);
    }
}

class Teacher : Person
{
    private string? subject;
    private int salary;

    public Teacher(string? name, int age, string? subject, int salary)
        : base(name, age)
    {
        this.subject = subject;
        this.salary = salary;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Subject : " + subject);
        Console.WriteLine("Salary : " + salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Teacher t1 = new Teacher(
            "Anuj",
            21,
            "Computer Science",
            50000
        );

        t1.DisplayInfo();
    }
}