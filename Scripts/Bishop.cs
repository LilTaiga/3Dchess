﻿using System.Collections.Generic;

public class Bishop : Piece
{
    ////////////////////////////
    //Variables and properties//
    ////////////////////////////

    private ChessColor pieceColor;
    protected override ChessColor PieceColor { get { return pieceColor; } }



    private Square location;
    protected override Square Location { get { return location; } }



    private bool hasMoved;
    protected override bool HasMoved { get { return hasMoved; } }



    private bool ignoreCollision;
    protected override bool IgnoreCollision { get; }

    ///////////
    //Methods//
    ///////////

    public override List<Square> ValidMoves()
    {
        //TODO: create algorithm to calculate what moves are possible for the bishop.
        return null;
    }

    public override List<Square> ValidAttackMoves()
    {
        //TODO: create algorithm to calculate what moves are valid when attacking with the bishop.
        return null;
    }

    public override List<Square> NoCaptureMoves()
    {
        //TODO: i dunno what this means, ask cleb.
        return null;
    }
}