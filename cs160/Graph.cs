using System.Collections;

namespace cs160;
public class GraphNode<T>
{

    public List<GraphNode<T>> Children { get; set; } = new List<GraphNode<T>>();
    public T Value { get; set; }

    public GraphNode(T value, List<GraphNode<T>> children)
    {
        this.Value = value;
        this.Children = children;
    }

    public int Size()
    {
        return Children.Count;
    }

    /// <summary>
    /// Add a child node to the children
    /// </summary>
    /// <param name="node">The node to add</param>
    public void AddChild(GraphNode<T> node)
    {
        Children.Add(node);
    }

    /// <summary>
    /// Deletes the node at the given index
    /// </summary>
    /// <param name="childIndex">The index of the children list</param>
    public void DeleteChild(int childIndex)
    {
        Children.RemoveAt(childIndex);
    }

    /// <summary>
    /// Updates the child at the given index with the new given node
    /// </summary>
    /// <param name="childIndex">The index of the node to change</param>
    /// <param name="newNode">The replacement node</param>
    public void UpdateChild(int childIndex, GraphNode<T> newNode)
    {
        Children[childIndex] = newNode;
    }

    /// <summary>
    /// Gets the node at the given index
    /// </summary>
    /// <param name="nodeIndex">The index of the node to retrieve</param>
    /// <returns>The node found</returns>
    public GraphNode<T> GetGraphNodeAtIndex(int nodeIndex)
    {
        return Children[nodeIndex];
    }
}