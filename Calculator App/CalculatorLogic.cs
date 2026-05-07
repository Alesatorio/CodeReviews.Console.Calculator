using MathOperation;
using Suport;

namespace Calculator_App;
// the code of this class works with the logic behind the calculations available in the calculator
internal class CalculatorLogic
{
    internal double basicOperation(Operation countType, double result)
    {
        Console.Clear();

        double num1, num2;
        Console.WriteLine("Type the First number: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Type the Second number: ");
        num2 = double.Parse(Console.ReadLine());

        switch (countType)
        {
            case Operation.Division:
                Helpers.secondNumIsZero(num2);
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

        Console.WriteLine(result);
        return result;
    }

    internal double powerOperation(double result)
    {
        double num1;
        int num2;
        Console.WriteLine("Type the number: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Type the Power: ");
        num2 = Int16.Parse(Console.ReadLine());

        result = Math.Pow(num1, num2);
        Console.WriteLine(result);
        return result;
    }
    internal double trigonometryOperation(double result)
    {
        double num1;
        Console.WriteLine("Type the number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine(@"Type the Function: 
                S - Sine
                C - Cosine
                T - Tangent
        ");
        
        string functionSelection = "";
        result = 0;
        

        do {
            functionSelection = Console.ReadLine();

            switch (functionSelection.Trim().ToLower())
            {
                case "s":
                    result = Math.Asin(num1);
                    break;

                case "c":
                    result = Math.Acos(num1);
                    break;

                case "t":
                    result = Math.Atan(num1);
                    break;

                default:
                    Console.WriteLine("Syntax Error - Try Again");
                    break;
            }
        } while (functionSelection != "s" && functionSelection != "c" && functionSelection != "t");

        Console.WriteLine(result);
        return result;
    }
    internal double squareRootOperation(double result)
    {
        double num1;
        Console.WriteLine("Type the number: ");
        num1 = double.Parse(Console.ReadLine());
        result = Math.Sqrt(num1);

        Console.WriteLine(result);
        return result;
    }
}
