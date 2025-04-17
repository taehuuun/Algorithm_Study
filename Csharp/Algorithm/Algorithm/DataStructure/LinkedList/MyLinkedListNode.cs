namespace Algorithm.DataStructure;

public class MyLinkedListNode<T>(T? data)
{
    public T? Data { get; private set; } = data;

    public MyLinkedListNode<T>? Next { get; set; }
    public MyLinkedListNode<T>? Prev { get; set; }

    public MyLinkedListNode() : this(default)
    {
    }
}