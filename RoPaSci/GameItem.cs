using System;

namespace GameItem
{
    [Flags]
    enum GameItem
    {
        Rock = 1 << 0,
        Paper = 1 << 1,
        Scissors = 1 << 2,
        
    }
}
