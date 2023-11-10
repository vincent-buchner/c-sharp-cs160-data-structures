using cs160;

class Program
{

    public static void Main() {
        cs160.Stack<string> myStack = new cs160.Stack<string>();

        myStack.Push("Hello");
        Console.WriteLine(myStack.ToString());

        myStack.Push("World");
        Console.WriteLine(myStack.ToString());

        myStack.Push("Hey");
        Console.WriteLine(myStack.ToString());

        myStack.Push("Mom!");
        Console.WriteLine(myStack.ToString());
    }
}