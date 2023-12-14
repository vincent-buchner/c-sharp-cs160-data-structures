namespace cs160;

public class DoublyLinkedListNode<T> {
    private DoublyLinkedListNode<T>? head;
    private T? value;
    private DoublyLinkedListNode<T>? tail;

    /// <summary>
    /// Creates a new Doubly Linked List Node that builds off given params
    /// </summary>
    /// <param name="headValue">The node to be stored in the head of the node</param>
    /// <param name="value">The value to be stored in the node</param>
    /// <param name="tailValue">The node to be stored in the tail of the node</param>
    public DoublyLinkedListNode(DoublyLinkedListNode<T> headNode, T value, DoublyLinkedListNode<T> tailNode) {
        this.head = headNode;
        this.value = value;
        this.tail = tailNode;
    }

    /// <summary>
    /// Creates a Doubly Linked List Node that only initially sets the value
    /// </summary>
    /// <param name="value">The value to be set in the value field of the node</param>
    public DoublyLinkedListNode(T value) {
        this.value = value;
    }

    /// <summary>
    /// An empty linked list node; head and tail are initially set to null
    /// </summary>
    public DoublyLinkedListNode() {
    
    }

    /// <summary>
    /// Gets the head value of the node
    /// </summary>
    /// <returns>The head value of type T</returns>
    public DoublyLinkedListNode<T>? GetHead() {
        return head;
    }

    /// <summary>
    /// Get the tail node stored in the current node
    /// </summary>
    /// <returns>The linking tail node</returns>
    public DoublyLinkedListNode<T>? GetTail() {
        return tail;
    }

    /// <summary>
    /// Get the value stored in the current node
    /// </summary>
    /// <returns>The value stored in the node</returns>
    public T? GetValue() {
        return value;
    }

    /// <summary>
    /// Assigns a new head to the node
    /// </summary>
    /// <param name="newHead">The new head node</param>
    public void SetHead(DoublyLinkedListNode<T> newHead) {
        head = newHead;
    }

    /// <summary>
    /// Sets a new link to the tail
    /// </summary>
    /// <param name="newTail">The new linked list node object</param>
    public void SetTail(DoublyLinkedListNode<T> newTail) {
        tail = newTail;
    }

    /// <summary>
    /// Sets the the value stored in the node to a new value
    /// </summary>
    /// <param name="newValue">The value to replace the current value</param>
    public void SetValue(T newValue) {
        value = newValue;
    }


}