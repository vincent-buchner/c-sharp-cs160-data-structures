namespace cs160;

public class Queue<T>
{   
    ////////////////////////////////////
    // PUBLIC AND PRIVATE ATTRIBUTES
    ////////////////////////////////////
    private List<T> queueList = new List<T>();

    ////////////////////////////////////
    // PUBLIC AND PRIVATE CONSTRUCTORS
    ////////////////////////////////////

    /// <summary>
    /// Creates a new instance of a queue
    /// </summary>
    public Queue() {

    }

    /// <summary>
    /// Creates a new instance of queue provided a list
    /// </summary>
    /// <param name="builtStack">The already built list</param>
    public Queue(List<T> builtStack) {
        queueList = builtStack;
    }

    /// <summary>
    /// Pushes an item into the end of the queue
    /// </summary>
    /// <param name="item">The item to be added</param>
    public void Push(T item) {
        this.queueList.Add(item);
    }

    /// <summary>
    /// Pops an item from the beginning of the queue
    /// </summary>
    /// <returns type="T">The item popped of the queue.</returns>
    public T Pop() {

        // Gets the item to be removed, then removes it
        T itemRemoved = this.queueList.ElementAt(0);
        this.queueList.RemoveAt(0);

        return itemRemoved;
    }

    /// <summary>
    /// Predicate for determining whether an instance of a class is empty.
    /// </summary>
    /// <returns>A boolean on whether the queue is empty. If True, the queue is empty.</returns>
    public bool IsEmpty() {

        // If the list is null or have no length, then it is empty
        if (this.queueList == null || this.queueList.Count <= 0) {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Calculates the size of the instance of the class
    /// </summary>
    /// <returns>A 32-bit integer on how big the queue is.</returns>
    public Int32 Size() {
        return this.queueList.Count;
    }
    
    /// <summary>
    /// Convert the queue data structure to a string
    /// </summary>
    /// <returns>The converted queue as a string</returns>
    public override string? ToString() {

        string baseString = "[";

        this.queueList.ForEach(item => {
            baseString += $" '{item}' ";
        });

        return baseString + "]";
    }
}
