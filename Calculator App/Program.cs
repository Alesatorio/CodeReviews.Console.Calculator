using Calculator_App;
using MathOperation;

CalculatorLogic calculator = new CalculatorLogic();

bool gameIsGoing = true;
double result = 0;
Console.WriteLine(" --- Calculator Programn ---");

do {
    Console.WriteLine(@"Choose an option: 
        
        A - Adition
        D - Division
        M - Multiplication
        S - Subtraction
        P - Power
        T - Trigonometry Functions
        SQR - Square Root
        Q - Quit
        ");

    string operationSelected = Console.ReadLine();

    switch (operationSelected.Trim().ToLower())
    {
        case "a":
            calculator.basicOperation(Operation.Adition, result);
            break;
        
        case "d":
            calculator.basicOperation(Operation.Division, result);
            break;

        case "m":
            calculator.basicOperation(Operation.Multiplication, result);
            break;

        case "s":
            calculator.basicOperation(Operation.Subtraction, result);
            break;

        case "p":
            calculator.powerOperation(result);
            break;

        case "t":
            calculator.trigonometryOperation(result);
            break;

        case "sqr":
            calculator.squareRootOperation(result);
            break;
        
        case "q":
            Console.WriteLine("Exiting Calculator");
            gameIsGoing = false;
            break;

        default:
            Console.WriteLine("Invalid option, try again");
            Console.Clear();
            break;
    }
    

} while (gameIsGoing);



