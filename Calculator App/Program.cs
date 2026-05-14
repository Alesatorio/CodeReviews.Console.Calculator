using Calculator_App;
using MathOperation;
using Suport;

CalculatorLogic calculator = new CalculatorLogic();

bool gameIsGoing = true;
double result = 0;
int calcUsed = 0;
Console.WriteLine(" --- Calculator Programn ---");

do {
    Console.Clear();
    Console.WriteLine(@$"Choose an option: 
        
        Count Of Times Used: {calcUsed}
                                            
        A - Adition
        D - Division
        M - Multiplication
        S - Subtraction
        P - Power
        T - Trigonometry Functions
        SQR - Square Root
        H - Counts History
        Q - Quit
        ");

    string? operationSelected = Console.ReadLine() ?? "";

    switch (operationSelected.Trim().ToLower())
    {
        case "a":
            calculator.basicOperation(Operation.Adition, result);
            calcUsed++;
            break;
        
        case "d":
            calculator.basicOperation(Operation.Division, result);
            calcUsed++;
            break;

        case "m":
            calculator.basicOperation(Operation.Multiplication, result);
            calcUsed++;
            break;

        case "s":
            calculator.basicOperation(Operation.Subtraction, result);
            calcUsed++;
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

        case "h":
            Helpers.addCountsToHistory();
            break;

        case "q":
            Console.WriteLine("Exiting Calculator");
            gameIsGoing = false;
            break;

        default:
            Console.WriteLine("Invalid option, try again");
            Console.ReadKey();
            Console.Clear();
            break;
    } 

} while (gameIsGoing);



