using System.Runtime.CompilerServices;

namespace cs160;

public class KaryTreeNode<T>
{

    public T Value { get; set; }
    private KaryTreeNode<T>[] children;
    public KaryTreeNode(T value, int k)
    {
        this.Value = value;
        children = new KaryTreeNode<T>[k];
    }

    /// <summary>
    /// Gets the child at the index
    /// </summary>
    /// <param name="childIndex">The index of the children within the range of 0 and k</param>
    /// <returns></returns>
    public KaryTreeNode<T> GetChild(int childIndex)
    {
        return children[childIndex];
    }

    /// <summary>
    /// Removes the child at that index
    /// </summary>
    /// <param name="childIndex">The index to remove at the given index</param>
    public void RemoveChild(int childIndex)
    {
        children[childIndex] = null;
    }

    /// <summary>
    /// Gets all the children of the node
    /// </summary>
    /// <returns>A array of size 'k' of the children nodes</returns>
    public KaryTreeNode<T>[] GetChildren()
    {
        return children;
    }

    /// <summary>
    /// Adds a child to the array of children
    /// </summary>
    /// <param name="childIndex">The index of the child to add to</param>
    /// <param name="treeNode">The tree node to add to</param>
    public void AddChild(int childIndex, KaryTreeNode<T> treeNode)
    {
        children[childIndex] = treeNode;
    }
}