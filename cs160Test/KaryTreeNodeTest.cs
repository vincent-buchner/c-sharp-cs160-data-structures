using cs160;

namespace cs160Test
{
    [TestClass]
    public class KaryTreeNodeTest
    {

        public static KaryTreeNode<string> root = new KaryTreeNode<string>("aaa", 2);

        [TestInitialize]
        public void buildTree()
        {
            KaryTreeNode<string> node1 = new KaryTreeNode<string>("bbb", 2);
            KaryTreeNode<string> node2 = new KaryTreeNode<string>("ccc", 2);
            KaryTreeNode<string> node3 = new KaryTreeNode<string>("ddd", 2);
            KaryTreeNode<string> node4 = new KaryTreeNode<string>("eee", 2);
            KaryTreeNode<string> node5 = new KaryTreeNode<string>("fff", 2);
            KaryTreeNode<string> node6 = new KaryTreeNode<string>("ggg", 2);

            root.AddChild(0, node1);
            root.AddChild(1, node2);

            node1.AddChild(0, node3);
            node1.AddChild(1, node4);

            node2.AddChild(0, node5);
            node2.AddChild(1, node6);
        }

        [TestMethod]
        public void InOrderTraversalTest()
        {
            Action<KaryTreeNode<string>>? inOrderTraversal = null;
            List<string> result = new List<string>();
            List<string> expected = new List<string>() { "ddd", "bbb", "eee", "aaa", "fff", "ccc", "ggg" };

            inOrderTraversal = (node) =>
            {
                if (node != null)
                {
                    inOrderTraversal(node.GetChild(0));
                    result.Add(node.Value);
                    inOrderTraversal(node.GetChild(1));
                }
            };

            inOrderTraversal(root);

            bool assertBoolean = result.SequenceEqual(expected);

            Assert.IsTrue(assertBoolean);
        }

        [TestMethod]
        public void PostOrderTraversalTest()
        {
            Action<KaryTreeNode<string>>? postOrderTraversal = null;
            List<string> result = new List<string>();
            List<string> expected = new List<string>() { "ddd", "eee", "bbb", "fff", "ggg", "ccc", "aaa" };

            postOrderTraversal = (node) =>
            {
                if (node != null)
                {
                    postOrderTraversal(node.GetChild(0));
                    postOrderTraversal(node.GetChild(1));
                    result.Add(node.Value);
                }
            };

            postOrderTraversal(root);

            bool assertBoolean = result.SequenceEqual(expected);

            Assert.IsTrue(assertBoolean);
        }
        
        [TestMethod]
        public void PreOrderTraversalTest()
        {
            Action<KaryTreeNode<string>>? preOrderTraversal = null;
            List<string> result = new List<string>();
            List<string> expected = new List<string>() { "aaa", "bbb", "ddd", "eee", "ccc", "fff", "ggg" };

            preOrderTraversal = (node) =>
            {
                if (node != null)
                {
                    result.Add(node.Value);
                    preOrderTraversal(node.GetChild(0));
                    preOrderTraversal(node.GetChild(1));
                }
            };

            preOrderTraversal(root);

            bool assertBoolean = result.SequenceEqual(expected);

            Assert.IsTrue(assertBoolean);
        }
    }
}