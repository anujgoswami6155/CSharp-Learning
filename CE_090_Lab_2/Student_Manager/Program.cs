using System;
using System.Collections.Generic;

List<string> studentList = new List<string>();

Console.WriteLine("========== Student Management System ==========");

int choice = 0;

do
{
    Console.WriteLine();
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Remove Student");
    Console.WriteLine("3. Display All Students");
    Console.WriteLine("4. Search Student");
    Console.WriteLine("5. Update Student");
    Console.WriteLine("6. Exit");

    Console.Write("\nEnter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter student name: ");
            string? addName = Console.ReadLine();

            if (studentList.Contains(addName))
            {
                Console.WriteLine("Student already exists.");
            }
            else
            {
                studentList.Add(addName);
                Console.WriteLine("Student added successfully.");
            }
            break;

        case 2:
            Console.Write("Enter student name to remove: ");
            string? removeName = Console.ReadLine();

            if (studentList.Contains(removeName))
            {
                studentList.Remove(removeName);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            break;

        case 3:
            if (studentList.Count == 0)
            {
                Console.WriteLine("No students available.");
            }
            else
            {
                Console.WriteLine("\n----- Student List -----");

                for (int i = 0; i < studentList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + studentList[i]);
                }
            }
            break;

        case 4:
            Console.Write("Enter student name to search: ");
            string? searchName = Console.ReadLine();

            if (studentList.Contains(searchName))
            {
                Console.WriteLine("Student '" + searchName + "' found in the list.");
            }
            else
            {
                Console.WriteLine("Student '" + searchName + "' not found.");
            }
            break;

        case 5:
            Console.Write("Enter the student name to update: ");
            string? oldName = Console.ReadLine();

            if (studentList.Contains(oldName))
            {
                Console.Write("Enter the new student name: ");
                string? newName = Console.ReadLine();

                studentList[studentList.IndexOf(oldName)] = newName;

                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            break;

        case 6:
            Console.WriteLine("Exiting the program...");
            break;

        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
            break;
    }

} while (choice != 6);