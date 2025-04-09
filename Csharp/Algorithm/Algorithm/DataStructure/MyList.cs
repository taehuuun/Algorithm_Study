namespace Algorithm.DataStructure;

public class MyList<T>
{
    public int Count { get; private set; }  // 실제 사용중인 데이터 수
    public int Capacity => _data.Length;    // 예약 할당 된 데이터 수
    
    private T?[] _data = new T?[_DEFAULT_SIZE];
    
    private const int _DEFAULT_SIZE = 1;

    // 시간 복잡도: O(1) 
    public void Add(T? item)
    {
        // 여유 공간이 있는지 확인
        // => 없다면, 새로운 배열을 현재 크기의 2배 만큼을 생성 후 기존 데이터를 이동 후 item 추가
        if (Count >= Capacity)
        {
            T?[] newArray = new T[Capacity * 2];
            
            Array.Copy(_data, newArray, Count);
            _data = newArray;
        }
        
        // => 있다면, 맨뒤에 item을 추가
        _data[Count] = item;
        Count++;
    }

    // 시간 복잡도: O(N)
    public bool Contains(T? item)
    {
        // 추가 된 데이터가 없다면 false
        if(Count == 0) return false;
        
        // 찾으려는 대상이 Null인 경우 false
        if(item == null) return false;

        // 배열을 돌며 일치하는 데이터가 있는 경우 true 리턴
        for (int i = 0; i < Count; i++)
        {
            if(item.Equals(_data[i]))
            {
                return true;
            }
        }

        // 없는 경우 false 리턴
        return false;
    }
    
    // 시간 복잡도: O(N)
    public void RemoveAt(int index)
    {
        for (int i = index; i < Count - 1; i++)
        {
            _data[i] = _data[i + 1];
        }
        
        Count--;
        _data[Count] = default;
    }

    // 시간 복잡도: O(1)
    public T? this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }
}