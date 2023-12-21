using cs160;

namespace cs160Test
{
    [TestClass]
    public class LambdaFunctionsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, LambdaFunctions.AddTwo(0, x => x * 2));
            Assert.AreEqual(10, LambdaFunctions.AddTwo(4, x => x * 2));
            Assert.AreEqual(22, LambdaFunctions.AddTwo(10, x => x * 2));

            Assert.AreEqual(2, LambdaFunctions.AddTwo(0, x => (int) Math.Pow(x, 2)));
            Assert.AreEqual(18, LambdaFunctions.AddTwo(4, x => (int) Math.Pow(x, 2)));
            Assert.AreEqual(11, LambdaFunctions.AddTwo(3, x => (int) Math.Pow(x, 2)));

            Func<int, int, int> sum = (x, y) => {
                return x + y;
            };
            
            Assert.AreEqual(4, LambdaFunctions.IteratedExponent(1, sum));
            Assert.AreEqual(46656, LambdaFunctions.IteratedExponent(3, sum));
            Assert.AreEqual(256, LambdaFunctions.IteratedExponent(2, sum));
        }
    }
}