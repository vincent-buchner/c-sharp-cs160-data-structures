namespace cs160Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class QueueTest
{
    [TestMethod]
    public void TestNullQueue()
    {
        cs160.Queue<string> myQueue = new cs160.Queue<string>();

        string expected = "[]";
        string? results = myQueue.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestAddQueue()
    {
        cs160.Queue<string> myQueue = new cs160.Queue<string>();
        myQueue.Push("aaa");
        myQueue.Push("bbb");
        myQueue.Push("ccc");

        string expected = "[ 'aaa'  'bbb'  'ccc' ]";
        string? results = myQueue.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestRemoveQueue()
    {
        cs160.Queue<string> myQueue = new cs160.Queue<string>();
        myQueue.Push("aaa");
        myQueue.Push("bbb");
        myQueue.Push("ccc");
        myQueue.Push("ddd");
        myQueue.Push("eee");
        myQueue.Push("fff");

        myQueue.Pop();
        myQueue.Pop();

        string expected = "[ 'ccc'  'ddd'  'eee'  'fff' ]";
        string? results = myQueue.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }
}