namespace Algorithm.DataStructure;

public class MyLinkedList<T>
{
    public int Count { get; private set; } = 0;

    private readonly MyLinkedListNode<T> _head = new();
    private readonly MyLinkedListNode<T> _tail = new();
    
    public MyLinkedListNode<T>? AddLast(T? data)
    {
        if(data == null)
        {
            return null;
        }

        MyLinkedListNode<T> newNode = new MyLinkedListNode<T>(data);
        
        // 아직 추가된 노드가 없는 경우 | [ head ] <-> [ tail ]
        if (Count == 0)
        {
            // [ head ] <-> [ newNode ] <-> [ tail ]
            _head.Next = newNode;
            
            newNode.Prev = _head;
        }
        
        // [ head ] <-> [...] <-> [ lastNode ] <-> [ tail ]
        if (_tail.Prev != null)
        {
            // [ head ] <-> [...] <-> [ lastNode ] <-> [ newNode ] <-> [ tail ]
            var lastNode = _tail.Prev;
            lastNode.Next = newNode;
            newNode.Prev = lastNode;
        }

        newNode.Next = _tail;
        _tail.Prev = newNode;

        Count++;
        
        return newNode;
    }
    public MyLinkedListNode<T>? AddFirst(T? data)
    {
        if (data == null)
        {
            return null;
        }

        var newNode = new MyLinkedListNode<T>(data);
        
        // [ head ] <-> [ tail ]
        if (Count == 0)
        {
            _tail.Prev = newNode;
            newNode.Next = _tail;
            
      
        }
        
        // [ head ] <-> [ firstNode ] <-> [...] <-> [ tail ]
        if (_head.Next != null)
        {
            // [ head ] <-> [newNode] <-> [ firstNode ] <-> [...] <-> [ tail ]
            var firstNode = _head.Next;
            
            firstNode.Prev = newNode;
            newNode.Next = firstNode;
        }
        
        _head.Next = newNode;
        newNode.Prev = _head;
        
        Count++;
        
        return newNode;
    }

    public void Print()
    {
        if(Count == 0)
        {
            Console.WriteLine("List is empty");
            return;
        }
        
        var current = _head.Next;
        while (current != _tail)
        {
            Console.Write(" " + current.Data);
            current = current.Next;
        }

        Console.WriteLine();
    }
}