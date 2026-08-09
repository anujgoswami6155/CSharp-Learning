using System;

namespace StudentOOP
{
    class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }

        public Student(int id, string? name, string? course)
        {
            Id = id;
            Name = name;
            Course = course;
        }

        public void display()
        {
            Console.WriteLine("Name of the student is: " + Name);
            Console.WriteLine("Roll No.: " + Id);
            Console.WriteLine("Course Enrolled : " + Course);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Anuj", "AI/ML");
            Student s2 = new Student(2, "Raj", "AI/ML");
            Student s3 = new Student(3, "Bhaumik", "SDE");
            Student s4 = new Student(4, "Manav", "SDE");
            Student s5 = new Student(5, "Bhavin", "UI/UX Designer");

            s1.display();
            s2.display();
            s3.display();
            s4.display();
            s5.display();
        }
    }
}
