using System;

namespace Calculator

{
    //Basic calculator

    class Calculator
    {
        //This is a basic calculator that is able to perform basic mathematical operations. + - X /
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to my calculator");
            
            int userSelection;
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1: Addition.");
                Console.WriteLine("2: Subtraction.");
                Console.WriteLine("3: Multiplication.");
                Console.WriteLine("4: Division.");
                Console.WriteLine("5: Square root.");
                Console.WriteLine("6: Raised to 2.");
                Console.WriteLine("9: Quit.");
                Console.WriteLine();
                userSelection = Convert.ToInt32(GetNumberFromUser("Menu selection"));
                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("1: Addition.\n  Input 2 numbers.");
                        Add();
                        break;
                    case 2:
                        Console.WriteLine("2: Subtraction.\n  Input 2 numbers.");
                        Subtract();
                        break;
                    case 3:
                        Console.WriteLine("3: Multiplication.\n  Input 2 numbers.");
                        Multiply();
                        break;
                    case 4:
                        Console.WriteLine("4: Division.\n  Input 2 numbers.");
                        Divide();
                        break;
                    case 5:
                        Console.WriteLine("5: Square root.\n  Input 1 number.");
                        Root();
                        break;
                    case 6:
                        Console.WriteLine("6.Exponentiation. Raised to 2.\n  Input 1 number.");
                        Exponet();
                        break;
                    case 9:
                        Console.WriteLine("Thanks for using this program.");
                        Console.WriteLine("Press any key to close program.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }
            } while (userSelection != 9);
        }  //End of Main
        static void Add()
        {
            double number1 = GetNumberFromUser("first");
            double number2 = GetNumberFromUser("second");
            double result = number1 + number2;
            Console.WriteLine("{0}+{1}={2}", number1, number2, result);
        }
        static void Subtract()
        {
            double number1 = GetNumberFromUser("first");
            double number2 = GetNumberFromUser("second");
            double result = number1 - number2;
            Console.WriteLine("{0}-{1}={2}", number1, number2, result);
        }

        static void Multiply()
        {
            double number1 = GetNumberFromUser("first");
            double number2 = GetNumberFromUser("second");
            double result = number1 * number2;
            Console.WriteLine("{0}x{1}={2}", number1, number2, result);
        }

        static void Divide()
        {
            double number1 = GetNumberFromUser("first");
            double number2;
            do
            {
                number2 = GetNumberFromUser("second");
                if (number2 == 0)
                    Console.WriteLine("Dividtion !! The second number must not be 0! Enter other number again!");
            } while (number2 == 0);


            double result = number1 * number2;
            Console.WriteLine("{0}x{1}={2}", number1, number2, result);
        }

        static void Root()
        {
            double number = GetNumberFromUser("a");
            double result = Math.Sqrt(number);
            Console.WriteLine("{0} Square root: {1}", number, result);
        }

        static void Exponet()
        {
            double number = GetNumberFromUser("a");
            double result = Math.Pow(number, 2);
            Console.WriteLine("{0} Power of 2: {1}", number, result);
        }
        static double GetNumberFromUser(string forWhat)
        {
            bool inputRight = false;
            double number = 0;
            string userInput="";
            do
            {
                try
                {
                    Console.Write("Enter " + forWhat + " number: ");
                    userInput = Console.ReadLine();
                    number=double.Parse(userInput);
                    inputRight = true;
                }
                catch
                {
                    Console.Write("Input fel. Enter a number.");
                    inputRight = false;
                }
            } while (!inputRight);
            
            return number;
        }
    }
}

