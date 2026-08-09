using System;
using System.Linq;
using System.Collections.Generic;


namespace LinqExample
{
    class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Department { get; set; }

        public int sem { get; set; }

        public int age { get; set; }

        public double CGPA { get; set; }

        public Student(int id, string? name, string? department, int sem, int age, double cGPA)
        {
            Id = id;
            Name = name;
            Department = department;
            this.sem = sem;
            this.age = age;
            CGPA = cGPA;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Anuj", "Computer Engineering", 5, 20, 9.28));
            students.Add(new Student(2, "Manav", "Computer Engineering", 5, 19, 9.28));
            students.Add(new Student(3, "Krishn", "Computer Engineering", 4, 19, 7.98));
            students.Add(new Student(4, "Meet", "Computer Applications", 4, 20, 8.26));
            students.Add(new Student(5, "Vraj", "Electrical Engineering", 6, 20, 7.73));
            students.Add(new Student(6, "Raj", "Chemical Engineering", 5, 20, 8.01));
            students.Add(new Student(7, "Bhaumik", "Computer Engineering", 6, 20, 8.83));
            students.Add(new Student(8, "Aarav", "Information Technology", 3, 19, 8.45));
            students.Add(new Student(9, "Riya", "Computer Engineering", 2, 18, 9.12));
            students.Add(new Student(10, "Nisha", "Civil Engineering", 6, 21, 8.34));
            students.Add(new Student(11, "Harsh", "Mechanical Engineering", 4, 20, 7.85));
            students.Add(new Student(12, "Sneha", "Electronics and Communication", 5, 20, 9.01));
            students.Add(new Student(13, "Yash", "Computer Applications", 3, 19, 8.18));
            students.Add(new Student(14, "Diya", "Electrical Engineering", 7, 22, 8.72));
            students.Add(new Student(15, "Karan", "Chemical Engineering", 8, 22, 7.64));
            students.Add(new Student(16, "Meera", "Information Technology", 5, 20, 9.56));
            students.Add(new Student(17, "Dev", "Civil Engineering", 2, 18, 8.09));


            var Result1 = from n in students
                          where n.CGPA >= 8.0
                          select n;

            Console.WriteLine("======================================================");
            Console.WriteLine("Students with CGPA >= 8.0");
            Console.WriteLine("======================================================");

            int count = 1;
            foreach (var item in Result1)
            {
                Console.WriteLine($"{count++}. {item.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.WriteLine("Computer Engineering Students (Sorted by CGPA)");
            Console.WriteLine("======================================================");

            var Result2 = (from n in students
                           where n.Department == "Computer Engineering"
                           select n).OrderByDescending(s => s.CGPA);

            count = 1;
            foreach (var item in Result2)
            {
                Console.WriteLine($"{count++}. {item.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.WriteLine("Top 3 Rankers");
            Console.WriteLine("======================================================");

            var rankers = ((from n in students
                            select n).OrderByDescending(s => s.CGPA)).Take(3);

            count = 1;
            foreach (var item in rankers)
            {
                Console.WriteLine($"{count++}. {item.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.WriteLine("Department-wise Student Count");
            Console.WriteLine("======================================================");

            var departments = (from n in students
                               select n.Department).Distinct();

            foreach (var item in departments)
            {
                var num = (from n in students
                           where n.Department == item
                           select n).Count();

                Console.WriteLine($"{item} : {num}");
            }

            Console.WriteLine();
            Console.WriteLine("======================================================");
            Console.WriteLine("End of Report");
            Console.WriteLine("======================================================");
        }
    }
}
