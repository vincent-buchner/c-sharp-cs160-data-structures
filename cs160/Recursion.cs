namespace cs160;

public class FibonacciSequence
{

    private static HashTable<int, int> memorization = new cs160.HashTable<int, int>(23);

    public static int SolveFibonacci(int num)
    {
        // If the sequence has been calculated, retrieve it
        if (memorization.Contains(num)) return memorization.GetValue(num);
        
        // Base case: 0 and 1 are in the fibonacci sequence
        if (num < 2) {
            memorization.Add(num, num);
            return num;
        }

        // Recursively solve fibonacci sequence for the given num and add it to the table
        int fib = SolveFibonacci(num - 1) + SolveFibonacci(num - 2);
        memorization.Add(num, fib);

        // Get the saved value in the table
        return memorization.GetValue(num);

    }
}