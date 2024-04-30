using System.Diagnostics;
using System.Drawing;

namespace Chess
{
    public class Pawn: Piece
    {
        public Pawn(Color color)
        {
            this.Color = color;
            InGame = true;
            Name = "Pawn";
            ShortName = "P";
        }

        public override bool IsValidMove(Cell from, Cell to)
        {
            // check if moving forward
            if (Color == Color.Black){
                if (to.row != from.row-1) return false;
            }
            else{
                if (to.row != from.row+1) return false;
            }
            // check if diagonal then opponent present in that cell
            if (to.col != from.col)
            {
                if (Math.Abs(to.col - from.col)>1) return false; // if not moving diagonal
                if (to.piece == null) return false; // if there is no opponent in diagonal cell
                if (to.piece.Color == from.piece.Color) return false;
            }
            else
            {
                if (to.piece != null) return false; // if target col is not empty
            }
            return true;
        }
    }
}