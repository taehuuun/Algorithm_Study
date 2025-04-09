namespace Algorithm;

class Program
{
    private const int _WAIT_TIME = 1000 / 30;
    
    static void Main(string[] args)
    {
        
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
        }
    }
}