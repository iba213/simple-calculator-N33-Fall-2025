using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            return double.Parse(argTextInput);
            //return Convert.ToDouble(input);
        }

        public static string ValidationOperator(string argOperatorInput)
        {
            string input = argOperatorInput.ToLower().Trim();

            if (input == "add" || input == "+"
                || input == "substract" || input == "-"
               || input == "multiply" || input == "*"
               || input == "divide" || input == "/")
            {
                return argOperatorInput;
            }else{
                return "invalid input";
            }
    
            
        }
    }
}
