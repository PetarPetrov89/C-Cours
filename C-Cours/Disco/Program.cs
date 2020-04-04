using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Disco is open");

            Console.WriteLine("Please enter a command");
            string command = Console.ReadLine();

            while (command != "stop")
            {
                switch (command)
                {
                    case "next":
                        AskForAge();
                        break;
                    case "pause":
                        Console.WriteLine("Disco is in pause");
                        break;
                    default:
                        Console.WriteLine("Please enter valid command");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Disco is closed");


        }

        private static void AskForAge()
        {
            Console.WriteLine("Please enter boy age:");
            int ageOfBoy = 0;

            if (!int.TryParse(Console.ReadLine(), out ageOfBoy))
            {
                Console.WriteLine("You entered invalid string. bye bye");
                return;
            }


            Console.WriteLine("Please enter girl age:");
            int ageOfGirl = 0;

            if (!int.TryParse(Console.ReadLine(), out ageOfGirl))
            {
                Console.WriteLine("You entered invalid string. bye bye");
                return;
            }

            if (ageOfBoy < 18 && ageOfGirl < 18)
            {
                Console.WriteLine("Leave");
            }
            else
            {
                if (ageOfBoy >= 18)
                {
                    Console.WriteLine("Enter");
                }
                else
                {
                    Console.WriteLine("Leave");
                }
            }
        }
    }
}
