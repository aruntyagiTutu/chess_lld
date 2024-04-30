using System.Diagnostics;

namespace Skeleton
{
    public class Pawn: Piece
    {
        public Pawn(int color)
        {
            this.Color = color;
            InGame = true;
        }

        public override bool IsValidMove()
        {
            return true;
        }
    }
}