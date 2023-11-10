using System.Collections;

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
}
