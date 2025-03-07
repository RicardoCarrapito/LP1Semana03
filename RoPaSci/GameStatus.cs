using System;

namespace GameStatus
{
    [Flags]
    enum GameStatus
    {
        draw = 1 << 0,
        Player1Wins = 1 << 1,
        Player2Wins = 1 << 2,
        
    }
}
