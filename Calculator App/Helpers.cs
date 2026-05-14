using MathOperation;
namespace Suport
{
    internal class Helpers
    {
        internal static List<MathDefinitions> History = new();
        
        internal static void addToHistory(Operation countType, double result)
        {
            History.Add(new MathDefinitions
            {
                Results = result,
                Type = countType
            });
        }
        
        internal static double secondNumIsZero()
        {
            double validNum;
            string? userNum = Console.ReadLine();

            while(string.IsNullOrEmpty(userNum) || !Double.TryParse(userNum, out validNum) || validNum == 0)
            {
                Console.Clear();
                Console.WriteLine("Enter a non-zero divisor: ");
                userNum = Console.ReadLine();

            }
            return validNum;
        }
        
        // this method verify if the user input is valid, although it obligates the user to type a valid number
        internal static double isUserAnswerValid()
        {
            double validNum;
            string? userNum = Console.ReadLine();
 
            while (string.IsNullOrEmpty(userNum) || !Double.TryParse(userNum, out validNum))
            {
                Console.WriteLine("Syntax Error - Type the number again:");
                userNum = Console.ReadLine();
                Console.Clear();
            }
            return validNum;
        }


        // this method verify if the pow from user input is valid, although it obligates the user to type a valid number
        internal static int powIsValid()
        {
            int validNum;
            string? userNum = Console.ReadLine();

            while (string.IsNullOrEmpty(userNum) || !Int32.TryParse(userNum, out validNum))
            {
                Console.WriteLine("Syntax Error - Type the number again:");
                userNum = Console.ReadLine();
                Console.Clear();
            }
            return validNum;
        }

        internal static double squareRootIsValid()
        {
            double validNum;
            string? userNum = Console.ReadLine();

            while (string.IsNullOrEmpty(userNum) || !double.TryParse(userNum, out validNum))
            {
                Console.WriteLine("Syntax Error - Type the number again:");
                userNum = Console.ReadLine();
                Console.Clear();
            }
            return validNum;
        }

        internal static double trigonometryNumIsValid()
        {
            double validNum;
            string? userNum = Console.ReadLine();

            while (string.IsNullOrEmpty(userNum) || !double.TryParse(userNum, out validNum))
            {
                Console.WriteLine("Syntax Error - Type the number again:");
                userNum = Console.ReadLine();
                Console.Clear();
            }
            return validNum;
        }
        
        internal static string trigonometrySelection()
        {
            string? selection = Console.ReadLine() ?? "";
            selection = selection.ToLower();

            while (string.IsNullOrEmpty(selection) || selection != "s" && selection != "c" && selection != "t")
            {
                Console.WriteLine(@"Syntax Error - Type a valid option:");
                selection = Console.ReadLine();                
                Console.Clear();
            }

            return selection;
        }

        internal static int selectionNumIsValid()
        {
            int validNum;
            string? userNum = Console.ReadLine();

            while (string.IsNullOrEmpty(userNum) || !int.TryParse(userNum, out validNum))
            {
                Console.WriteLine("Type a valid number :");
                userNum = Console.ReadLine();
                Console.Clear();
            }
            return validNum;
        }

        internal static void addCountsToHistory()
        {
            int enhancer = 1, selection = 0;
            foreach(var count in History)
            {
                Console.WriteLine($"{count.Type}: {count.Results}  | {enhancer++}");
            }
            Console.ReadKey();
            Console.WriteLine("Make a new count using previus results, type the related number: ");
            selection = selectionNumIsValid();

            Console.WriteLine($"{History.ElementAt(selection).Results * 2.9}");

        }

    }
}
