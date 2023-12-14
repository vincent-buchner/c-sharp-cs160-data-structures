namespace cs160Test;

[TestClass]
public class DoublyLinkedListTest
{
    [TestMethod]
    public void TestEmptyDoublyLinkedListNode()
    {
        cs160.DoublyLinkedListNode<string> doublyLinkedListNode = new cs160.DoublyLinkedListNode<string>();
        Assert.IsNull(doublyLinkedListNode.GetValue());
        Assert.IsNull(doublyLinkedListNode.GetHead());
        Assert.IsNull(doublyLinkedListNode.GetTail());
    }

    [TestMethod]
    public void TestOnlyValueLinkedListNode()
    {
        cs160.DoublyLinkedListNode<string> doublyLinkedListNode = new cs160.DoublyLinkedListNode<string>("aaa");
        Assert.IsTrue(doublyLinkedListNode.GetValue() == "aaa");
        Assert.IsNull(doublyLinkedListNode.GetHead());
        Assert.IsNull(doublyLinkedListNode.GetTail());
    }

    [TestMethod]
    public void TestGetSizeFromBackLinkedListNode()
    {
        cs160.DoublyLinkedListNode<string> dll1 = new cs160.DoublyLinkedListNode<string>("aaa");
        cs160.DoublyLinkedListNode<string> dll2 = new cs160.DoublyLinkedListNode<string>("bbb");
        cs160.DoublyLinkedListNode<string> dll3 = new cs160.DoublyLinkedListNode<string>("ccc");
        cs160.DoublyLinkedListNode<string> dll4 = new cs160.DoublyLinkedListNode<string>("ddd");
        cs160.DoublyLinkedListNode<string> dll5 = new cs160.DoublyLinkedListNode<string>("eee");

        dll1.SetTail(dll2);

        dll2.SetHead(dll1);
        dll2.SetTail(dll3);

        dll3.SetHead(dll2);
        dll3.SetTail(dll4);

        dll4.SetHead(dll3);
        dll4.SetTail(dll5);

        dll5.SetHead(dll4);

        cs160.DoublyLinkedListNode<string> currentNode = dll5;
        Int32 counter = 0;

        while (currentNode != null) {
            counter += 1;

            currentNode = currentNode.GetHead();
        }

        Assert.IsTrue(counter == 5);

    }

    [TestMethod]
    public void TestGetSizeFromFrontLinkedListNode()
    {
        cs160.DoublyLinkedListNode<string> dll1 = new cs160.DoublyLinkedListNode<string>("aaa");
        cs160.DoublyLinkedListNode<string> dll2 = new cs160.DoublyLinkedListNode<string>("bbb");
        cs160.DoublyLinkedListNode<string> dll3 = new cs160.DoublyLinkedListNode<string>("ccc");
        cs160.DoublyLinkedListNode<string> dll4 = new cs160.DoublyLinkedListNode<string>("ddd");
        cs160.DoublyLinkedListNode<string> dll5 = new cs160.DoublyLinkedListNode<string>("eee");

        dll1.SetTail(dll2);

        dll2.SetHead(dll1);
        dll2.SetTail(dll3);

        dll3.SetHead(dll2);
        dll3.SetTail(dll4);

        dll4.SetHead(dll3);
        dll4.SetTail(dll5);

        dll5.SetHead(dll4);

        cs160.DoublyLinkedListNode<string> currentNode = dll1;
        Int32 counter = 0;

        while (currentNode != null) {
            counter += 1;

            currentNode = currentNode.GetTail();
        }

        Assert.IsTrue(counter == 5);
    }
}
