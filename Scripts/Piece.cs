using System.Collections.Generic;

public abstract class Piece
{
    //////////////
    //Properties//
    //////////////
    //To be implemented in each subclass.
    protected abstract ChessColor PieceColor { get; }
    protected abstract Square Location { get; }
    protected abstract bool HasMoved { get; }
    protected abstract bool IgnoreCollision { get; }


    ///////////
    //Methods//
    ///////////
    public abstract List<Square> ValidMoves();

    public abstract List<Square> ValidAttackMoves();

    public abstract List<Square> NoCaptureMoves();

    public virtual bool IsCaptured()
    {
        //TODO: somehow check if this piece was captured before.
        return false;
    }
}
