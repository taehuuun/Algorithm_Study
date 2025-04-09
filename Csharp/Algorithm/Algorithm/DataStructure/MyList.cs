namespace Algorithm.DataStructure;

public class MyList<T>
{
    public int Count { get; private set; }  // 실제 사용중인 데이터 수
    public int Capacity => _data.Length;    // 예약 할당 된 데이터 수
    
    private T?[] _data = new T?[_DEFAULT_SIZE];
    
    private const int _DEFAULT_SIZE = 1;

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

    public void RemoveAt(int index)
    {
        for (int i = index; i < Count - 1; i++)
        {
            _data[i] = _data[i + 1];
        }
        
        Count--;
        _data[Count] = default;
    }

    public T? this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }
}