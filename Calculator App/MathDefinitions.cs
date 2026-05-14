namespace MathOperation;

internal class MathDefinitions
{
    public Operation Type { get; set; }
    public Double Results { get; set; }
}

internal enum Operation
{
    Multiplication,
    Division,
    Subtraction,
    Adition
}