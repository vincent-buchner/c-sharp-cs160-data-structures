namespace cs160;

public class Stack<T>
{   
    ////////////////////////////////////
    // PUBLIC AND PRIVATE ATTRIBUTES
    ////////////////////////////////////
    private List<T> stackList = new List<T>();

    ////////////////////////////////////
    // PUBLIC AND PRIVATE CONSTRUCTORS
    ////////////////////////////////////

    /// <summary>
    /// Creates a new instance of a stack
    /// </summary>
    public Stack() {

    }

    /// <summary>
    /// Creates a new instance of stack provided a list
    /// </summary>
    /// <param name="builtStack">The already built list</param>
    public Stack(List<T> builtStack) {
        stackList = builtStack;
    }

    /// <summary>
    /// Pushes an item to the top of the stack
    /// </summary>
    /// <param name="item"></param>
    public void Push(T item) {
        this.stackList.Add(item);
    }

    /// <summary>
    /// Pops an item from the top of the stack
    /// </summary>
    /// <returns type="T">The item popped of the stack.</returns>
    public T Pop() {

        // Gets the item to be removed, then removes it
        T itemRemoved = this.stackList.ElementAt(this.stackList.Count - 1);
        this.stackList.RemoveAt(this.stackList.Count - 1);

        return itemRemoved;
    }

    /// <summary>
    /// Predicate for determining whether an instance of a class is empty.
    /// </summary>
    /// <returns>A boolean on whether the stack is empty. If True, the stack is empty.</returns>
    public bool IsEmpty() {

        // If the list is null or have no length, then it is empty
        if (this.stackList == null || this.stackList.Count <= 0) {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Calculates the size of the instance of the class
    /// </summary>
    /// <returns>A 32-bit integer on how big the stack is.</returns>
    public Int32 Size() {
        return this.stackList.Count;
    }
    
    /// <summary>
    /// Convert the stack data structure to a string
    /// </summary>
    /// <returns>The converted stack as a string</returns>
    public override string? ToString() {

        string baseString = "[";

        this.stackList.ForEach(item => {
            baseString += $" '{item}' ";
        });

        return baseString + "]";
    }
}
