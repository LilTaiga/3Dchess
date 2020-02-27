using System.Collections.Generic;

public class Pieces
{
    private List<Piece> pieceList;
    private ChessColor color;

    public List<Piece> PieceList
    {
        get { return pieceList; }
        set
        {
            //TODO: find an algorithm to modify the piece list.
        }
    }

    public ChessColor Color
    {
        get { return color; }
        set
        {
            //TODO: discuss if this property really needs a set modifier.
        }
    }
}
