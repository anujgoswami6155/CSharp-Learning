using System;
using System.Collections.Generic;

int cnt = 1;
Stack<string> stk = new Stack<string>();
stk.Push($"Web Page {cnt}");

int n;

while (true)
{
    Console.WriteLine("\n===== Browser Menu =====");
    Console.WriteLine("1. Visit New Webpage");
    Console.WriteLine("2. Go Back");
    Console.WriteLine("3. View Current Page");
    Console.WriteLine("4. Display Browsing History");
    Console.WriteLine("5. Close Browser");
    Console.Write("Enter your choice: ");

    n = Convert.ToInt32(Console.ReadLine());

    switch (n)
    {
        case 1:
            {
                Console.Write("Enter webpage name: ");
                string? page = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(page))
                {
                    cnt++;
                    page = $"Web Page {cnt}";
                }

                stk.Push(page);
                Console.WriteLine("New page added successfully.");
                break;
            }

        case 2:
            {
                if (stk.Count > 1)
                {
                    Console.WriteLine(stk.Pop() + " closed.");
                    Console.WriteLine("Current Page: " + stk.Peek());
                }
                else
                {
                    Console.WriteLine("Cannot go back. This is the first page.");
                }
                break;
            }

        case 3:
            {
                Console.WriteLine("Current Page: " + stk.Peek());
                break;
            }

        case 4:
            {
                Console.WriteLine("\nBrowsing History:");
                foreach (string page in stk)
                {
                    Console.WriteLine(page);
                }
                break;
            }

        case 5:
            {
                Console.WriteLine("Browser Closed Successfully.");
                return;
            }

        default:
            {
                Console.WriteLine("Invalid Choice! Please try again.");
                break;
            }
    }
}