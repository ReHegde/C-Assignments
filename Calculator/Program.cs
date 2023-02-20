using System;
using System.Text;
using System.Threading.Tasks;
namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.Write("Enter First Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Symbol (/,+,-,*): ");
            string symbol = Console.ReadLine(); 
            switch (symbol)
            {
                case "+":
                    result = n1 + n2;
                    Console.WriteLine("Addition: " + result);
                    break;
                case "-":
                    result = n1 - n2;
                    Console.WriteLine("Subtraction: " + result);
                    break;
                case "*":
                    result = n1 * n2;
                    Console.WriteLine("Multiplication: " + result);
                    break;
                case "/":
                    result = n1 / n2;
                    Console.WriteLine("Division: " + result);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.ReadLine();
        }
    }
}

