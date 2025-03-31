
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Threading.Tasks;

namespace Assignment {
    public class Assignment1
    {

        /*
         * 1.Understanding Console Methods:
            -What is the difference between `Console.WriteLine()` and `Console.Write()`? Provide examples.
            - Modify the program to display a multi-line welcome message using multiple `Console.WriteLine()` calls.
        */
        public void Ex1()
        {
            Console.WriteLine("Hello this is write line method");
            Console.Write("Hello this is write methods");
        }

        /*
         * 2.User Input and String Interpolation:
             - Prompt the user to input their age and favorite color.Display the inputs back using string interpolation.
             - Extend the program to ask for the user's name, age, and profession, then display a personalized message such as:\
             `"Hello, John! You are 25 years old and work as a Software Engineer."`
        */

        public void Ex2()
        {
            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your favorite color: ");
            string color = Convert.ToString(Console.ReadLine());
            Console.Write("Enter name :");
            string name = Console.ReadLine();
            Console.Write("Enter your profession :");
            string profession = Console.ReadLine();

            string details = $"Hii {name} ! You are {age} years old and work as a {profession}";

            Console.WriteLine(details);
        }

        /*
         * 3.Formatted Output:
            - Write a program to calculate and display a table of square and cube values for integers from 1 to 10 
              using formatted output(Padding the values by 0's for 6 digits) Ex: square of 2 is 4 the o/p should be: 000004.
         */

        public string GetPadding(int num,int maxLength, char paddingCharacter)
        {

            return Convert.ToString(num).PadLeft(maxLength, paddingCharacter);
        }
        public void Ex3()
        {
            char paddingCharacter = '0';
            int maxLength = 6;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Table for  {i} : ");
                for(int j = 1; j < 11; j++)
                {
                    int num = i * j;
                    string res  = $"{GetPadding(num, 3, ' ')}"+
                                  " = " +
                                  $"{GetPadding(num * num, maxLength, paddingCharacter)}" +
                                  " "+
                                  $"{GetPadding(num * num * num, maxLength, paddingCharacter)}";

                    Console.WriteLine(res);
                }
                Console.WriteLine();
            }

        }

        /*
         * 4.Input Validation:
           Extend the program to validate user input. For example, if the user enters a non-numeric value for age, 
           display an error message and prompt again.
         */

        public void Ex4()
        {
            bool isValidAge = false;
            do
            {
                Console.Write("Enter Age :");
                string input = Console.ReadLine();
                try
                {
                    int age = Convert.ToInt32(input);
                    Console.WriteLine($"Entered age is {age}");
                    isValidAge = true;
                }
                catch
                {
                    Console.WriteLine("Enter valid age format");
                }
            } while (!isValidAge);   
        }

        /*
         * 5.Conditional Logic:
           - Write a program that asks the user to guess a number between 1 and 10.
             If the guess is correct, display "Correct!" Otherwise, display "Try Again.
         * 
         */

        public void Ex5()
        {
            Console.WriteLine("-------- Number Guess Game -------");

            bool isWin = false;
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            
            do
            {
                
                Console.Write("Guess number between 1-10 :");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("Congratulation, You won...!!! ");
                    isWin = true;
                }
                else
                {
                    Console.WriteLine("Opps, Try again ...!!! ");
                }

            } while(!isWin);
        }

        /*
         *  6.Menu System:
            - Create a basic menu-driven console application with options like:
             1. Accept user details and Display the same with welcome message
             2. Ask user to enter his/her age and print if they are Teenager(<18) or adult (>18)
             3. Exit Application
            - Allow the user to choose options by entering a number.
         * */
       public void Ex6()
        {
            int key = 0;
            do
            {


                Console.WriteLine("1.Enter user details :");
                Console.WriteLine("2.Check are you teenager of adult :");
                Console.WriteLine("3.Exit");

                Console.WriteLine("Enter you choice :");

                key = Convert.ToInt32(Console.ReadLine());
              
                if (key == 1)
                {
                    Console.Write("Enter Your Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Your favorite color: ");
                    string color = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter name :");
                    string name = Console.ReadLine();
                    Console.Write("Enter your profession :");
                    string profession = Console.ReadLine();

                    string details = $"Welcome {name} ! You are {age} years old and work as a {profession}";

                    Console.WriteLine(details);
                }
                else if (key == 2)
                {
                    Console.Write("Enter Your Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 18)
                    {
                        Console.WriteLine("You are Teenager");
                    }
                    else
                    {
                        Console.WriteLine("You are Adult");
                    }

                }

            } while (key != 3);
        }

        /*
         * 
            7.Interactive Calculator:
            - Create a basic calculator program that supports addition, subtraction, multiplication, and division. 
            Prompt the user for two numbers and the desired operation. 

         * */
        public void menu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
            Console.WriteLine("6.mod");
            Console.WriteLine("5.Exit");
            Console.WriteLine("===================================");


        }
        public int add(int num1,int num2)
        {
            return num1 + num2;
        }
        public int sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int div(int num1, int num2)
        {
            return num1 / num2;
        }
        public int mod(int num1, int num2)
        {
            return num1 % num2;
        }
        public void Ex7()
        {
            int key;
            do
            {
                menu();

                Console.Write("Enter number 1 : " );
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select operation : ");

                key = Convert.ToInt32(Console.ReadLine());

                if (key == 1)
                {
                    Console.WriteLine($"{num1} + {num2} = {add(num1, num2)}");
                }
                else if (key == 2)
                {
                    Console.WriteLine($"{num1} - {num2} = {sub(num1, num2)}");

                }
                else if (key == 3)
                {
                    Console.WriteLine($"{num1} * {num2} = {mul(num1, num2)}");

                }
                else if (key == 4)
                {
                    Console.WriteLine($"{num1} / {num2} = {div(num1, num2)}");

                }
                else if (key == 6)
                {
                    Console.WriteLine($"{num1} % {num2} = {mod(num1, num2)}");

                }
            } while (key != 5);
        }
    }
    
    public class UpdatedAssignment
    {
        // 1a. Shuffle first and last characters
        public string ShuffleFirstLast(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
                return input;

            char[] chars = input.ToCharArray();
            char temp = chars[0];
            chars[0] = chars[chars.Length - 1];
            chars[chars.Length - 1] = temp;

            return new string(chars);
        }

        // 1b. Sum of digits
        public int SumOfDigits(int number)
        {
            number = Math.Abs(number); // Handle negative numbers
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        // 2a. Palindrome check without recursion
        public bool IsPalindrome(int number)
        {
            if (number < 0) return false;

            string numStr = number.ToString();
            int left = 0;
            int right = numStr.Length - 1;

            while (left < right)
            {
                if (numStr[left] != numStr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        // 2a. Palindrome check with recursion
        public bool IsPalindromeRecursive(string numStr, int start, int end)
        {
            if (start >= end)
                return true;

            if (numStr[start] != numStr[end])
                return false;

            return IsPalindromeRecursive(numStr, start + 1, end - 1);
        }

        // 2b. Square root with exception handling
        public double CalculateSquareRoot(double number)
        {
            try
            {
                if (number < 0)
                    throw new ArgumentException("Cannot calculate square root of a negative number");

                return Math.Sqrt(number);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1; // Indicate error
            }
        }

        public void TestAssignment1()
        {
            // Test 1a
            Console.WriteLine("Enter a string to shuffle first and last characters:");
            string input1 = Console.ReadLine();
            Console.WriteLine($"Result: {ShuffleFirstLast(input1)}");

            // Test 1b
            Console.WriteLine("\nEnter an integer to sum its digits:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of digits: {SumOfDigits(num1)}");

            // Test 2a (non-recursive)
            Console.WriteLine("\nEnter a number to check if it's palindrome:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Is palindrome (non-recursive): {IsPalindrome(num2)}");

            // Test 2a (recursive)
            string numStr = num2.ToString();
            Console.WriteLine($"Is palindrome (recursive): {IsPalindromeRecursive(numStr, 0, numStr.Length - 1)}");

            // Test 2b
            Console.WriteLine("\nEnter a number to calculate its square root:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double result = CalculateSquareRoot(num3);
            if (result != -1)
                Console.WriteLine($"Square root: {result}");
        }
    }
}
