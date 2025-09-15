using System;
using static System.Net.Mime.MediaTypeNames;


namespace CalcLib
{ 

    public static class CalculatorEngine
    {
        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            //You can use switch case also here for multiple operations or use if-else-if ladder
            double result = 0;
            

            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
                
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiplication")
            {
                result = argFirstNumber * argSecondNumber;
                
            }
            else if (argOperation == "/" || argOperation.ToLower() == "division")
            {
                result = argFirstNumber / argSecondNumber;
               
            }
            else if (argOperation == "-" || argOperation.ToLower() == "substraction")
            {
                result = argFirstNumber - argSecondNumber;
                
            }
            else if (argOperation.ToLower() == "modulus" || argOperation == "%")
            {
                result = argFirstNumber % argSecondNumber;
                
            }
            else
            {
                throw new InvalidOperationException("");
            }


                return result;
            }
}
    }

 