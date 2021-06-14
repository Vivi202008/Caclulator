using System;

namespace Calculator

{
    //Basic calculator
    
    class Calculator
    {
        //This is a basic calculator that is able to perform basic mathematical operations. + - X /
        public double number1=0, number2=0, result=0;
        public string operatorString="";
        public void Main(string[] args)
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
                Console.WriteLine("5: Root.");
                Console.WriteLine("6: Exponentiation..");

                Console.WriteLine("0: Quit.");
                Console.WriteLine();
                userSelection = Convert.ToInt32(GetNumberFromUser("Menu selection"));
                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("1: Addition.\tInput 2 numbers.");
                        Input2numbers();
                        Add();
                        break;
                    case 2:
                        Console.WriteLine("2: Subtraction.\tInput 2 numbers.");
                        Input2numbers();
                        Subtract();
                        break;
                    case 3:
                        Console.WriteLine("3: Multiplication.\tInput 2 numbers.");
                        Input2numbers(); 
                        Multiply();
                        break;
                    case 4:
                        Console.WriteLine("4: Division.\tInput 2 numbers.");
                        Input2numbers(); 
                        Divide();
                        break;
                    case 5:
                        Console.WriteLine("5: Root. The nth root of a number\tInput 2 number.");
                        Input2numbers();
                        Root();
                        break;
                    case 6:
                        Console.WriteLine("6.Exponentiation. Raised to the power of n.\tInput 2 number.");
                        Input2numbers();
                        Exponet();
                        break;
                 
                                  
                    case 0:
                        Console.WriteLine("Thanks for using this program.");
                        Console.WriteLine("Press any key to close program.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }
            } while (userSelection != 0);

            printResult();
        }  //End of Main

        public void Add()
        {
            result = number1 + number2;
            operatorString = "+";
        }
        public void Input2numbers()
        {
            number1 = GetNumberFromUser("first");
            number2 = GetNumberFromUser("second");
        }

         void Subtract()
        {
            result = number1 - number2;
            operatorString = "-";
        }

         void Multiply()
        {
            result = number1 * number2;
            operatorString = "*";
        }

        void printResult() {
            Console.WriteLine("{0} {1} {2} = {3}", number1, operatorString, number2, result);
        }

         void Divide()
        {
            //Divisor cannot be 0       
                while (number2 == 0)
                {
                    Console.WriteLine("Dividtion !! Divisor cannot be 0! Enter other number again!");
                    number2 =GetNumberFromUser("second");
                }
 
            result = number1 / number2;
            operatorString = "/";
        }

         void Root()
        {
            while (number2 < 2 || number2 != Math.Round(number2)) ;
            {   //Nth root, n>=2
                 Console.WriteLine(" !! The root number must be a integer that more than 1  ! Enter other number again!");
                 number2 = GetNumberFromUser("second");
             } 

            result = Math.Pow(number1,1/number2);
            operatorString = " root ";
        }

         void Exponet()
        {
            while (number2 != Math.Round(number2)) 
            {   //Nth power, n is a integer
                Console.WriteLine(" !! The exponent must be a integer that more than 1  ! Enter other number again!");
                number2 = GetNumberFromUser("second");

            } 

            while (number2 ==0 && number1==0) 
            {   //they can't be 0---exponetion
                  Console.WriteLine(" The exponent and base cannot be 0 at the same time! Enter other number again!");
                    number1 = GetNumberFromUser("first");
            } 

            result = Math.Pow(number1, number2);
           operatorString=" Raise the power of ";
        }
        public double GetNumberFromUser(string forWhat)
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

