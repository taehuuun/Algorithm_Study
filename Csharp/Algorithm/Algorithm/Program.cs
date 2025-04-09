namespace Algorithm;

class Program
{
    private const int _WAIT_TIME = 1000 / 30;
    private const char _CIRCLE = '\u25cf';
    
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        
        int lastTick = 0;
        
        while (true)
        {
            #region 프레임

            int currentTick = Environment.TickCount;
            
            // 만약 경과한 시간이 1/30초 보다 작다면 continue
            if (currentTick - lastTick < _WAIT_TIME)
            {
                continue;
            }
            
            lastTick = currentTick;

            #endregion
            
            // 입력
            
            // 로직
            
            // 렌더링
            Console.SetCursorPosition(0, 0);
            
            for(int y = 0; y < 25; y++)
            {
                for(int x = 0; x < 25; x++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(_CIRCLE);
                }
                
                Console.WriteLine();
            }
        }
    }
}