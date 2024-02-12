

public class TStack<T> where T : struct
{
    private List<T> _stack;
    private int top;

    public TStack()
    {
        _stack = new List<T>();
        top = -1; 
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public T? Peek()
    {
        return _stack[top];
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty. Cannot Pop.");
        }
        T item = _stack[top];
        _stack.RemoveAt(top);
        top--;
        return item;
    }

    public void Push(T item)
    {
        top++;
        _stack.Add(item);
    }

    public void Display()
    {
        int i = top;
        while (i > 0)
        {
            Console.WriteLine(_stack[i]);
            i--;
        }
    }
}