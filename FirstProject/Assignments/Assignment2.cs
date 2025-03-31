using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirstProject.Assignments
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        public MyCustomException(int errorCode, string errorDescription)
            : base(errorDescription)
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
        }
    }

    public class Assignment2
    {
        public int DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(1001, "Division by zero is not allowed");
            }
        }

        public int GetArrayElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(1002, "Array index is out of bounds");
            }
        }

        public void TestAssignment2()
        {
            try
            {
                // Test division by zero
                Console.WriteLine("Testing division...");
                int result1 = DivideNumbers(10, 0);
                Console.WriteLine($"Result: {result1}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Error Code: {ex.ErrorCode}");
                Console.WriteLine($"Error Description: {ex.ErrorDescription}");
            }

            try
            {
                // Test array index out of range
                Console.WriteLine("\nTesting array access...");
                int[] numbers = { 1, 2, 3 };
                int result2 = GetArrayElement(numbers, 5);
                Console.WriteLine($"Result: {result2}");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Error Code: {ex.ErrorCode}");
                Console.WriteLine($"Error Description: {ex.ErrorDescription}");
            }
        }
    }
}
