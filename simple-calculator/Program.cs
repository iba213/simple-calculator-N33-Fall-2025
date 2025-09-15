using CalcLib;
using SimpleCalculator;
using System;
using System.Text;


namespace SimpleCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                
                
                Console.WriteLine("Welcome to Simple Calculator\nEnter  your first number then press Enter:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter  your Second number then press Enter:");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter operation wanted (add, +, etc) then press Enter:");
                string operation = Console.ReadLine();

                double result = CalculatorEngine.Calculate(operation, firstNumber, secondNumber);
                StringBuilder outputMessage = new StringBuilder();
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
