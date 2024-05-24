namespace Params;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Result: {PrintParams(1, 2, 3, 4, 5)}"); //implicit cast to int[]
    }

    private static string PrintParams(params int[] inputParams)
    {
        return $"Sum: {inputParams.Sum()}";
    }
}
