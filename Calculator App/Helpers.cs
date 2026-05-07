using MathOperation;
namespace Suport
{
    internal class Helpers
    {
        internal static void secondNumIsZero(double num2)
        {
            while(num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}
