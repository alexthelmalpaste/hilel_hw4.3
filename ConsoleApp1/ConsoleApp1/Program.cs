namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an operation (/ * - +):");
            string method = Console.ReadLine();

            switch (method)
            {
                case "/":
                    if (second != 0)
                        Console.WriteLine($"Result: {first} / {second} = {first / (double)second}");
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                case "*":
                    Console.WriteLine($"Result: {first} * {second} = {first * second}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {first} - {second} = {first - second}");
                    break;
                case "+":
                    Console.WriteLine($"Result: {first} + {second} = {first + second}");
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    break;
            }
        }
    }
}
