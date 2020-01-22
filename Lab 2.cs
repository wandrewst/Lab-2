using System;

namespace Lab_Tuesday2
{
    class Program
    {
        static void Main(string[] args)
        {
         string answer;
        do
         {        
            Console.WriteLine("Please write the WIDTH of your rectangle:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please write the HEIGHT of your rectangle:");
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("The AREA of your rectangle is: {0}", area);
            Console.WriteLine("The PERIMETER of your rectangle is: {0}", perimeter);

        
            Console.Write("Another room again? (Y/N): ");
                answer = Console.ReadLine().ToUpper();
        } while (answer != "Y" && answer != "N");
        
                while (answer == "Y");
            {
                break;
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();

        }
    }
}
