namespace Chess
{
    public  abstract class Piece
    {
        public int Color;
        public bool InGame;
        public int Level;

        // Actions
        public abstract bool IsValidMove();
    }
}