using System;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one number between 1 and 3");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("You got a new car !");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane !");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike !");
                    break;
                default:
                    Console.WriteLine("You have entered wrong number !");
                    break;

            }
            Console.ReadLine();
        }
    }
}
