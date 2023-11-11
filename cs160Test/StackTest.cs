namespace cs160Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StackTest
{
    [TestMethod]
    public void TestNullStack()
    {
        cs160.Stack<string> myStack = new cs160.Stack<string>();

        string expected = "[]";
        string? results = myStack.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestAddStack()
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
    public void TestRemoveStack()
    {
        cs160.Stack<string> myStack = new cs160.Stack<string>();
        myStack.Push("aaa");
        myStack.Push("bbb");
        myStack.Push("ccc");

        myStack.Pop();
        myStack.Pop();

        string expected = "[ 'aaa' ]";
        string? results = myStack.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }
}