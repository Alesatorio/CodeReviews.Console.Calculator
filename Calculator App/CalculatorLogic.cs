using MathOperation;
using Suport;

namespace Calculator_App;
// the code of this class works with the logic behind the calculations available in the calculator
internal class CalculatorLogic
{
    // calculates the main operations (+-/*)
    internal double basicOperation(Operation countType, double result)
    {
        Console.Clear();

        double num1, num2;
        Console.WriteLine("Type the First number: ");
        num1 = Helpers.isUserAnswerValid();

        Console.WriteLine("Type the Second number: ");
        num2 = Helpers.isUserAnswerValid();

        switch (countType)
        {
            case Operation.Division:
                if(num2 == 0)            
                {
                    num2 = Helpers.secondNumIsZero();
                }            
                break;
        }

        result = countType switch
        {
            Operation.Division => num1 / num2,
            Operation.Multiplication => num1 * num2,
            Operation.Adition => num1 + num2,
            Operation.Subtraction => num1 - num2,
            _ => throw new ArgumentException("Syntax Error")
        };

        Helpers.addToHistory(countType, result);
        Console.Clear();
        Console.WriteLine(result);
        Console.ReadKey();
        
        return result;
    }
    // calculates the power of a number
    internal double powerOperation(double result)
    {
        Console.Clear();

        double num1;
        int num2;
        Console.WriteLine("Type the number: ");
        num1 = Helpers.isUserAnswerValid();

        Console.WriteLine("Type the Power: ");
        num2 = Helpers.powIsValid();

        result = Math.Pow(num1, num2);

        Console.Clear();
        Console.WriteLine(result);
        Console.ReadKey();

        return result;
    }
    
    // calculates the sin, cos and tan of an angle
    internal double trigonometryOperation(double result)
    {
        Console.Clear();

        string selection;
        double num;
        Console.WriteLine("Type the number: ");
        num = Helpers.trigonometryNumIsValid();
        
        Console.WriteLine(@"Type the Function: 
                
                S - Sine
                C - Cosine
                T - Tangent
        ");
        
        selection = Helpers.trigonometrySelection();

        switch (selection)
        {
            case "s":
                result = Math.Sin(num);
                break;

            case "c":
                result = Math.Cos(num);
                break;

            case "t":
                result = Math.Tan(num);
                break;

            default:
                Console.WriteLine("Error");
                break;
        }
        
        Console.Clear();
        Console.WriteLine(result);
        Console.ReadKey();
        
        return result;
    }
    
    // this method calculates the square root of a number
    internal double squareRootOperation(double result)
    {
        Console.Clear();
        double num;
        Console.WriteLine("Type the number: ");
        num = Helpers.squareRootIsValid();
        result = Math.Sqrt(num);

        Console.Clear();
        Console.WriteLine(result);
        Console.ReadKey();
        
        return result;
    }
}
