namespace cs160;

public class LinkedListNode<T> {
    private T? head;
    private LinkedListNode<T>? tail;

    /// <summary>
    /// Creates a new Linked List Node that builds off given params
    /// </summary>
    /// <param name="headValue">The value to be stored in the head of the node</param>
    /// <param name="tailValue">The link to the next Linked List Node</param>
    public LinkedListNode(T headValue, LinkedListNode<T> tailValue) {
        this.head = headValue;
        this.tail = tailValue;
    }

    /// <summary>
    /// Creates a Linked List Node that only initially sets the head value
    /// </summary>
    /// <param name="headValue">The value to be set to the head</param>
    public LinkedListNode(T headValue) {
        this.head = headValue;
    }

    /// <summary>
    /// An empty linked list node; head and tail are initially set to null
    /// </summary>
    public LinkedListNode() {
    
    }

    /// <summary>
    /// Gets the head value of the node
    /// </summary>
    /// <returns>The head value of type T</returns>
    public T? GetHead() {
        return head;
    }

    /// <summary>
    /// Get the linking tail value
    /// </summary>
    /// <returns>The linked list node linked to</returns>
    public LinkedListNode<T>? GetTail() {
        return tail;
    }

    /// <summary>
    /// Assigns a new head to the node
    /// </summary>
    /// <param name="newHead">The new head value</param>
    public void SetHead(T newHead) {
        head = newHead;
    }

    /// <summary>
    /// Sets a new link to the tail
    /// </summary>
    /// <param name="newTail">The new linked list node object</param>
    public void SetTail(LinkedListNode<T> newTail) {
        tail = newTail;
    }


}