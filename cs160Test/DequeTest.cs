namespace cs160Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]

public class DequeTest
{
    [TestMethod]
    public void TestNullDeque() {
        cs160.Deque<string> myDeque = new cs160.Deque<string>();

        string expected = "[]";
        string? results = myDeque.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestAddFrontDeque() {
        cs160.Deque<string> myDeque = new cs160.Deque<string>();

        myDeque.PushFront("aaa");
        myDeque.PushFront("bbb");
        myDeque.PushFront("ccc");

        string expected = "[ 'ccc'  'bbb'  'aaa' ]";
        string? results = myDeque.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestAddBackDeque() {
        cs160.Deque<string> myDeque = new cs160.Deque<string>();

        myDeque.PushBack("aaa");
        myDeque.PushBack("bbb");
        myDeque.PushBack("ccc");

        string expected = "[ 'aaa'  'bbb'  'ccc' ]";
        string? results = myDeque.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestPopBackDeque() {
        cs160.Deque<string> myDeque = new cs160.Deque<string>();

        myDeque.PushBack("aaa");
        myDeque.PushBack("bbb");
        myDeque.PushBack("ccc");

        myDeque.PopBack();
        myDeque.PopBack();

        string expected = "[ 'aaa' ]";
        string? results = myDeque.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestPopFrontDeque() {
        cs160.Deque<string> myDeque = new cs160.Deque<string>();

        myDeque.PushBack("aaa");
        myDeque.PushBack("bbb");
        myDeque.PushBack("ccc");

        myDeque.PopFront();
        myDeque.PopFront();

        string expected = "[ 'ccc' ]";
        string? results = myDeque.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }

    [TestMethod]
    public void TestPopEndsDeque() {
        cs160.Deque<string> myDeque = new cs160.Deque<string>();

        myDeque.PushBack("aaa");
        myDeque.PushBack("bbb");
        myDeque.PushBack("ccc");

        myDeque.PopFront();
        myDeque.PopBack();

        string expected = "[ 'bbb' ]";
        string? results = myDeque.ToString();

        Assert.IsTrue(expected == results, $"Results came back false: Expected {expected}; Actual {results}");
    }
}