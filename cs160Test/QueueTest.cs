namespace cs160Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class QueueTest
{
    [TestMethod]
    public void TestNullQueue()
    {
        cs160.Stack<string> myQueue = new cs160.Stack<string>();

        string expected = "[]";
        string? results = myQueue.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestAddQueue()
    {
        cs160.Stack<string> myStack = new cs160.Stack<string>();
        myStack.Push("aaa");
        myStack.Push("bbb");
        myStack.Push("ccc");

        string expected = "[ 'aaa'  'bbb'  'ccc' ]";
        string? results = myStack.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestRemoveQueue()
    {
        cs160.Stack<string> myStack = new cs160.Stack<string>();
        myStack.Push("aaa");
        myStack.Push("bbb");
        myStack.Push("ccc");
        myStack.Push("ddd");
        myStack.Push("eee");
        myStack.Push("fff");

        myStack.Pop();
        myStack.Pop();

        string expected = "[ 'ccc'  'ddd'  'eee'  'fff' ]";
        string? results = myStack.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }
}