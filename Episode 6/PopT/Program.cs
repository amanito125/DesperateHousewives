Stack<int> stack = new Stack<int>();
stack.items = new List<int>();
stack.Count = 0;
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(15);
Console.WriteLine(stack.Pop());



class Stack<T> {
    public int Count { get; set; }
    public IList<T> items { get; set; }
    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("empty stack");
        }
        this.Count--;
        T element = this.items.Last();

        T[] temp = new T[this.items.Count];
        for (int i = 0; i < this.Count; i++)
        {
            temp[i] = this.items[i];
        }

        this.items = temp;
        return element;
    }
    public void Push(T element)
    {
        this.Count++;
        T[] temp = new T[this.Count];
        for (int i = 0; i < this.Count - 1; i++)
        {
            temp[i] = this.items[i];
        }
        temp[this.Count - 1] = element;
        this.items = temp;
    }
}

