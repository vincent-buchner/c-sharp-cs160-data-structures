using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cs160Test;

[TestClass]
public class LinkedListNodeTest
{
    [TestMethod]
    public void TestCreateEmptyLinkedListNode()
    {
        cs160.LinkedListNode<string> emptyNode = new cs160.LinkedListNode<string>();
        Assert.IsNull(emptyNode.GetHead());
        Assert.IsNull(emptyNode.GetTail());
    }

    [TestMethod]
    public void TestCreateHeadLinkedListNode()
    {
        cs160.LinkedListNode<string> headNode = new cs160.LinkedListNode<string>("Hey Mom!");
        Assert.IsNull(headNode.GetTail());
        Assert.IsTrue(headNode.GetHead() == "Hey Mom!");
    }

    [TestMethod]
    public void TestCreateWholeLinkedListNode()
    {
        cs160.LinkedListNode<string> node1 = new cs160.LinkedListNode<string>("Hey Mom!");
        cs160.LinkedListNode<string> node2 = new cs160.LinkedListNode<string>("Hey Dad!", node1);
        
        Assert.IsNull(node1.GetTail());
        Assert.IsTrue(node1.GetHead() == "Hey Mom!");

        Assert.IsTrue(node2.GetHead() == "Hey Dad!");
        Assert.IsTrue(node2.GetTail() == node1);
    }

    [TestMethod]
    public void TestLinkedListNodeLinks()
    {
        cs160.LinkedListNode<string> node5 = new cs160.LinkedListNode<string>("eee");
        cs160.LinkedListNode<string> node4 = new cs160.LinkedListNode<string>("ddd", node5);
        cs160.LinkedListNode<string> node3 = new cs160.LinkedListNode<string>("ccc", node4);
        cs160.LinkedListNode<string> node2 = new cs160.LinkedListNode<string>("bbb", node3);
        cs160.LinkedListNode<string> node1 = new cs160.LinkedListNode<string>("aaa", node2);

        cs160.LinkedListNode<string> currentNode = node1;
        Int32 expectedSize = 5;
        Int32 resultedSize = 0;

        while (currentNode != null) {
            resultedSize += 1;
            currentNode = currentNode.GetTail();
        }

        Assert.IsTrue(expectedSize == resultedSize, $"Results do not match: Expected {expectedSize}, Actual {resultedSize}");
        
    }
}
