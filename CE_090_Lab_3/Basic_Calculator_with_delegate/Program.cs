namespace Calc
{
    class Prgram
    {
        delegate double Calculator(double a, double b);

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" : Calculator Options : ");
            Console.WriteLine("1 : Addition");
            Console.WriteLine("2 : Substraction");
            Console.WriteLine("3 : Multiplication");
            Console.WriteLine("4 : Division");
            Console.WriteLine("Select any Option : ");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Two Number : ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Calculator c;
            switch (n)
            {
                case 1:
                    c = Add;
                    Console.WriteLine("Addition is : " + c(a, b));
                    break;
                case 2:
                    c = Sub;
                    Console.WriteLine("Substraction is : " + c(a, b));
                    break;
                case 3:
                    c = Mul;
                    Console.WriteLine("Multiplication is : " + c(a, b));
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Division not possible b cannot be 0");
                        break;
                    }
                    c = Div;
                    Console.WriteLine("Division is : " + c(a, b));
                    break;
                default:
                    Console.WriteLine("Enter Vaild Option from 1 - 5 only");
                    break;
            }
        }
    }
}
