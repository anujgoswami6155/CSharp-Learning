using System;

namespace StudentOOP
{
    class Student
    {
        // Private fields
        private int id;
        private string? name;
        private string? course;

        // Public properties with validation
        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Roll Number must be positive.");
                }
                else
                {
                    id = value;
                }
            }
        }

        public string? Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string? Course
        {
            get { return course; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Course cannot be empty.");
                }
                else
                {
                    course = value;
                }
            }
        }

        // Constructor
        public Student(int id, string? name, string? course)
        {
            Id = id;
            Name = name;
            Course = course;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("Name of the student is: " + Name);
            Console.WriteLine("Roll No.: " + Id);
            Console.WriteLine("Course Enrolled: " + Course);
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

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

            // Testing validation
            s1.Id = -10;
            s1.Name = "";
            s1.Course = "";
        }
    }
}