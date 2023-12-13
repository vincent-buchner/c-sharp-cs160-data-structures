namespace cs160;

public class Deque<T> {

    private List<T> dequeList = new List<T>();

    /// <summary>
    /// Creates an empty deque
    /// </summary>
    public Deque() {

    }

    /// <summary>
    /// Creates a deque from the provided list
    /// </summary>
    /// <param name="builtDeque">A list of items</param>
    public Deque(List<T> builtDeque) {
        this.dequeList = builtDeque;
    }

    /// <summary>
    /// Pushes an item into the front of the queue
    /// </summary>
    /// <param name="item">The item to be added</param>
    public void PushFront(T item) {
        this.dequeList.Insert(0, item);
    }

    /// <summary>
    /// Pushes an item into the front of the queue
    /// </summary>
    /// <param name="item">The item to be added</param>
    public void PushBack(T item) {
        this.dequeList.Add(item);
    }

    /// <summary>
    /// Pops an item from the front of the queue
    /// </summary>
    public T PopFront() {
        
        // Gets the item to be removed, then removes it
        T itemRemoved = this.dequeList.ElementAt(0);
        this.dequeList.RemoveAt(0);

        return itemRemoved;
    }

    /// <summary>
    /// Pops an item from the back of the queue
    /// </summary>
    public T PopBack() {
        
        // Gets the item to be removed, then removes it
        T itemRemoved = this.dequeList.ElementAt(this.dequeList.Count - 1);
        this.dequeList.RemoveAt(this.dequeList.Count - 1);

        return itemRemoved;
    }

    /// <summary>
    /// Determines whether the current deque is empty or not 
    /// </summary>
    /// <returns>If deque is empty, returns true.</returns>
    public bool IsEmpty() {
                // If the list is null or have no length, then it is empty
        if (this.dequeList == null || this.dequeList.Count <= 0) {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Calculates the size of the instance of the class
    /// </summary>
    /// <returns>A 32-bit integer on how big the deque is.</returns>
    public Int32 Size() {
        return this.dequeList.Count;
    }

    /// <summary>
    /// Convert the deque data structure to a string
    /// </summary>
    /// <returns>The converted deque as a string</returns>
    public override string? ToString() {

        string baseString = "[";

        this.dequeList.ForEach(item => {
            baseString += $" '{item}' ";
        });

        return baseString + "]";
    }
}