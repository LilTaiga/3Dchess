public enum ChessColor 
{ 
    White = 1, 
    Black = -1
}
public enum EndState 
{ 
    WhiteWins = 1, 
    Draw = 0, 
    BlackWins = -1
}
public enum CheckState 
{ 
    BlackCheckmate = -2, 
    BlackCheck = -1, 
    None = 0, 
    WhiteCheck = 1, 
    WhiteCheckmate = 2 
}
public enum BoardDirection 
{ 
    Up = 1, 
    Down = -1 
}
