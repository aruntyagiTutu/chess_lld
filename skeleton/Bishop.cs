namespace Skeleton
{
    public class Bishop: Piece
    {
        public Bishop(int color)
        {
            Color = color;
            InGame = true;
        }

        public override bool IsValidMove()
        {
            throw new NotImplementedException();
        }
    }
}