using cs160;

namespace cs160Test;

[TestClass]
public class GraphTest
{

    public static cs160.GraphNode<string>? node1;
    public static cs160.GraphNode<string>? node2;
    public static cs160.GraphNode<string>? node3;
    public static cs160.GraphNode<string>? node4;   
    public static cs160.GraphNode<string>? node5;   
    public static cs160.GraphNode<string>? node6;
    [TestInitialize]
    public void BuildGraph()
    {
        node1 = new cs160.GraphNode<string>("aaa", new List<cs160.GraphNode<string>>());
        node2 = new cs160.GraphNode<string>("bbb", new List<cs160.GraphNode<string>>());
        node3 = new cs160.GraphNode<string>("ccc", new List<cs160.GraphNode<string>>());
        node4 = new cs160.GraphNode<string>("ddd", new List<cs160.GraphNode<string>>());
        node5 = new cs160.GraphNode<string>("eee", new List<cs160.GraphNode<string>>());
        node6 = new cs160.GraphNode<string>("fff", new List<cs160.GraphNode<string>>());

        node1.AddChild(node2);
        node1.AddChild(node3);
        node1.AddChild(node4);

        node2.AddChild(node5);
        
        node3.AddChild(node5);
        node3.AddChild(node6);

        node4.AddChild(node6);
    }

    [TestMethod]
    public void TestGetChildren()
    {
        bool result1 = new List<GraphNode<string>>().SequenceEqual(node5.Children);
        bool result2 = new List<GraphNode<string>>().SequenceEqual(node6.Children);

        Assert.IsTrue(result1);
        Assert.IsTrue(result2);

        int size = node1.Size();
        Assert.AreEqual(3, size);
    }

    [TestMethod]
    public void TestAddChild()
    {
       node1.AddChild(new GraphNode<string>("zzz", new List<GraphNode<string>>()));
       Assert.AreEqual(4, node1.Size());
    }

    [TestMethod]
    public void TestRemoveChild()
    {
        node1.DeleteChild(0);
        node1.DeleteChild(1);

        Assert.AreEqual(1, node1.Size());
        
    }

    [TestMethod]
    public void TestUpdateChild()
    {
        node1.UpdateChild(0, new GraphNode<string>("zzz", new List<GraphNode<string>>(){node5}));

        Assert.AreEqual(node1.Children[0].Value, "zzz");
    }
}