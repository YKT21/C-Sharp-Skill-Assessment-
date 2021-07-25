using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Prompt user to enter interger value
            Console.WriteLine(" Enter the interger value: ");
            int x = int.Parse(Console.ReadLine());
            // Prompt user to enter operator
            Console.WriteLine("Enter an operator Addition +, Subtraction -, Multiplication *, Division /");
            string op = Console.ReadLine();
            // prompt user to enter the second value
            Console.WriteLine(" Enter the interger value: ");
            int y = int.Parse(Console.ReadLine());
            // calculate the result
            if (op == "+")
                Console.WriteLine($"{x} plus {y} is equal {x + y}");
            else if (op == "-")
                Console.WriteLine($"{x} minus {y} is equal {x - y}");
            else if (op == "*")
                Console.WriteLine($"{x} time {y} is equal {x * y}");
            else if (op == "/")
                Console.WriteLine($"{x} divide {y} is equal {x / y}");

        }
    }
}
