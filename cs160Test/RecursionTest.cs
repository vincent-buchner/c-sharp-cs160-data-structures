using cs160;

namespace cs160Test
{
    [TestClass]
    public class RecursionTest
    {
        [TestMethod]
        public void TestFibonacciSequence()
        {
           Assert.AreEqual(1, FibonacciSequence.SolveFibonacci(1)); 
           Assert.AreEqual(610, FibonacciSequence.SolveFibonacci(15)); 
           Assert.AreEqual(832040, FibonacciSequence.SolveFibonacci(30)); 
           Assert.AreEqual(4181, FibonacciSequence.SolveFibonacci(19)); 
           Assert.AreEqual(28657, FibonacciSequence.SolveFibonacci(23)); 
           Assert.AreEqual(55, FibonacciSequence.SolveFibonacci(10)); 
           Assert.AreEqual(317811, FibonacciSequence.SolveFibonacci(28)); 
        }
    }
}