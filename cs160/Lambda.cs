namespace cs160;

public class LambdaFunctions
{

    /// <summary>
    /// Takes the result of the lambda function and adds two to it
    /// </summary>
    /// <param name="number">The number to add to lambda</param>
    /// <param name="func">The lambda function to add to</param>
    /// <returns>An int representing the lambda function plus two</returns>
    public static int AddTwo(int number, Func<int, int> func)
    {
        return func(number) + 2;
    }

    /// <summary>
    /// Performs the operation n^n, where n is the result of the lambda function
    /// </summary>
    /// <param name="number">The number to be plugged into lambda</param>
    /// <param name="func">The lambda function of two params to plug number into</param>
    /// <returns>An integer representing n^n</returns>
    public static int IteratedExponent(int number, Func<int, int, int> func)
    {
        return (int) Math.Pow(func(number, number), func(number, number));
    }
}